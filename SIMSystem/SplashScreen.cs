using MySql.Data.MySqlClient;
using SIMSystem.Forms;

namespace SIMSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoadAll()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                //create user table if not exists
                MySqlCommand Create_user_table = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS user 
                    (emp_id VARCHAR(12) NOT NULL,
                    emp_userName VARCHAR(255) NOT NULL,
                    emp_password VARCHAR(255) NOT NULL,
                    emp_dateJoined  TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
                    emp_firstName VARCHAR(255) NOT NULL,
                    emp_lastName VARCHAR(255) NOT NULL,
                    emp_profileImage MEDIUMBLOB NULL,
                    emp_email VARCHAR(100) NOT NULL,
                    emp_address VARCHAR(100) NOT NULL,
                    emp_type VARCHAR(50) NOT NULL,
                    emp_isOnline Boolean DEFAULT FALSE,
                    emp_isNotifEnabled Boolean, 
                    emp_isActive BOOLEAN DEFAULT TRUE,
                    emp_signature MEDIUMBLOB NULL,
                    PRIMARY KEY (emp_id)) COLLATE='utf8_general_ci';", connection.connection);
                Create_user_table.ExecuteNonQuery();

                //create supply table if not exists
                MySqlCommand Create_supply_table = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS supply
                    (supply_name VARCHAR(50) NOT NULL,
                    supply_poNumber VARCHAR(50) NOT NULL,
                    supply_quantity INT NOT NULL,
                    supply_cLevel INT NOT NULL,
                    supply_type VARCHAR(50) NOT NULL,
                    supply_unit VARCHAR(50) NOT NULL,
                    supply_yearAdded VARCHAR(4),
                    supply_unitCost DOUBLE NOT NULL,
                    supply_totalCost DOUBLE NOT NULL,
                    PRIMARY KEY (supply_name)) COLLATE='utf8_general_ci';", connection.connection);
                Create_supply_table.ExecuteNonQuery();

                //create requisitionIssueSlip table if not exists
                MySqlCommand Create_ris_table = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS requisitionIssueSlip
                    (ris_number VARCHAR(50) NOT NULL,
                    ris_requesterId VARCHAR(12) NOT NULL,
                    ris_entityName VARCHAR(255) NOT NULL,
                    ris_division VARCHAR(255) NOT NULL,
                    ris_office VARCHAR(255) NOT NULL,
                    ris_fundCluster VARCHAR(255) NOT NULL,
                    ris_purpose VARCHAR(255) NOT NULL,
                    ris_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    ris_isApproved Boolean DEFAULT FALSE,
                    ris_isPending Boolean DEFAULT TRUE,
                    ris_rejectnote VARCHAR(255) NULL,
                    ris_cssdate TIMESTAMP NULL,
                    ris_sodate TIMESTAMP NULL,
                    PRIMARY KEY (ris_number),
                    FOREIGN KEY (ris_requesterId) REFERENCES User(emp_id)) COLLATE='utf8_general_ci';", connection.connection);
                Create_ris_table.ExecuteNonQuery();

                //create risrequester table if not exists
                MySqlCommand Create_ris_requester_table = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS risRequester
                    (rr_id INT NOT NULL AUTO_INCREMENT,
                    rr_name VARCHAR(255) NOT NULL,
                    rr_risNumber VARCHAR(50) NOT NULL,
                    rr_designation VARCHAR(50),
                    rr_signature MEDIUMBLOB NOT NULL,
                    PRIMARY KEY(rr_id),
                    FOREIGN KEY(rr_risNumber) REFERENCES requisitionIssueSlip(ris_number)) COLLATE='utf8_general_ci';", connection.connection);
                Create_ris_requester_table.ExecuteNonQuery();

                //create table for itemrequested if not exists
                MySqlCommand create_requestedSupply_table = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS supplyRequested
                    (sr_id INT NOT NULL AUTO_INCREMENT,
                    sr_supply VARCHAR(50) NOT NULL,
                    sr_quantity INT NOT NULL,
                    sr_risId VARCHAR(50) NOT NULL,
                    sr_unit VARCHAR(50) NOT NULL,
                    sr_unitCost DOUBLE NOT NULL,
                    PRIMARY KEY (sr_id),
                    FOREIGN KEY (sr_risId) REFERENCES requisitionIssueSlip(ris_number)) COLLATE='utf8_general_ci';", connection.connection);
                create_requestedSupply_table.ExecuteNonQuery();

                //create logfile table if not exists
                MySqlCommand createLogFile = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS logFile
                    (log_id INT NOT NULL AUTO_INCREMENT,
                    log_userId VARCHAR(12) NOT NULL,
                    log_event VARCHAR(255) NOT NULL,
                    log_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    PRIMARY KEY(log_id),
                    FOREIGN KEY(log_userId) REFERENCES User(emp_id)) COLLATE='utf8_general_ci';", connection.connection);
                createLogFile.ExecuteNonQuery();

                //create porecords table if not exists
                MySqlCommand createPORecords = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS poRecords
                    (por_id INT NOT NULL AUTO_INCREMENT,
                    por_supplyName VARCHAR(255) NOT NULL,
                    por_supplyCount INT NOT NULL,
                    por_supplyTotalCost INT NOT NULL,
                    PRIMARY KEY (por_id)) COLLATE='utf8_general_ci';", connection.connection);
                createPORecords.ExecuteNonQuery();

                //create autodocid
                MySqlCommand createAutoDocId = new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS autodocid
                    (auto_Id INT NOT NULL AUTO_INCREMENT,
                    auto_type VARCHAR(50) NOT NULL UNIQUE,
                    auto_count INT NOT NULL,
                    PRIMARY KEY(auto_Id)) COLLATE='utf8_general_ci';", connection.connection);
                createAutoDocId.ExecuteNonQuery();

                //create an entry for risID
                MySqlCommand createRisAutoId = new MySqlCommand(@"
                    INSERT IGNORE INTO autodocid(auto_type, auto_count) VALUES('RIS', 0)", connection.connection);
                createRisAutoId.ExecuteNonQuery();

                //create announcement table if not exists
                MySqlCommand createNoticeTable = new MySqlCommand(@"
                CREATE TABLE IF NOT EXISTS announcement
                (ann_id INT NOT NULL AUTO_INCREMENT,
                ann_what VARCHAR(255) NOT NULL,
                ann_who VARCHAR(100) NOT NULL,
                ann_where VARCHAR(100) NOT NULL,
                ann_when TIMESTAMP NOT NULL,
                emp_id VARCHAR(12),
                ann_createdAt TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                PRIMARY KEY(ann_id),
                FOREIGN KEY(emp_id) REFERENCES User(emp_id)) COLLATE='utf8_general_ci';", connection.connection);
                createNoticeTable.ExecuteNonQuery();

                //create message table if not exists
                MySqlCommand createMessage = new MySqlCommand(@"
                CREATE TABLE IF NOT EXISTS message
                (message_id INT NOT NULL AUTO_INCREMENT,
                message_from VARCHAR(12) NOT NULL,
                message_to VARCHAR(12) NOT NULL,
                message_content VARCHAR(255) NOT NULL,
                message_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
                PRIMARY KEY(message_id),
                FOREIGN KEY(message_from) REFERENCES User(emp_id),
                FOREIGN KEY(message_to) REFERENCES User(emp_id)) COLLATE='utf8_general_ci';", connection.connection);
                createMessage.ExecuteNonQuery();


                //closes the connection
                connection.Close();

                //redirect to defaultDashboard after loading
                DefaultDashboard defaultDashboard = new DefaultDashboard();
                defaultDashboard.Show();
                Hide();
            }
            else
            {
                ConnectionDB.FailMessage();
                Close();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateConfig updateConfig = new UpdateConfig();
            updateConfig.ShowDialog();
        }
    }
}