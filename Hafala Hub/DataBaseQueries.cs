using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hafala_Hub
{
    public class DataBaseQueries
    {
        //database stuff
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "hafalahub";
        private const String UID = "root";
        private const String PASSWORD = "1831998";
        private const int PORT = 3306;
        private static MySqlConnection dbConn;

        // User class stuff
        public int id { get; private set; }

        public String ActivityID { get; private set; }

        private DataBaseQueries(String id)
        {
            ActivityID = id;
        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Port = PORT;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;



            String connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        public static List<Activity> getActivities()
        {
            List<Activity> activities = new List<Activity>();
            List<int> int_activities = new List<int>();

            String query = "select * from activities;";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);


            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Activity newActivity = new Activity(reader.GetInt32("activity_id"), reader["activity_header"].ToString(), reader["activity_summary"].ToString(), reader.GetInt32("activity_severity"), reader["activity_inserter"].ToString(), reader["activity_leaders"].ToString(), reader.GetDateTime("activity_start_datetime").ToString(), reader.GetDateTime("activity_end_datetime").ToString(), reader.GetChar("activity_started"), reader.GetChar("activity_paused"), reader.GetChar("activity_stopped"));
                activities.Add(newActivity);

            }
            Console.WriteLine(reader);

            dbConn.Close();

            return activities;

        }

        public static List<string> GetActivitiesExistence()
        {
            List<string> activitiesID = new List<string>();

            String query = "select activity_id from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityid = reader["activity_id"].ToString();
                activitiesID.Add(activityid);
            }

            reader.Close();

            dbConn.Close();

            return activitiesID;
        }

        public static List<string> GetActivitiesID()
        {
            List<string> activitiesID = new List<string>();

            String query = "select activity_id from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityid = reader["activity_id"].ToString();
                activitiesID.Add(activityid);
            }

            reader.Close();

            dbConn.Close();

            return activitiesID;
        }

        public static List<string> GetActivitiesHeader()
        {
            List<string> activitiesHeader = new List<string>();

            String query = "select activity_header from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityheader = reader["activity_header"].ToString();
                activitiesHeader.Add(activityheader);
            }

            reader.Close();

            dbConn.Close();

            return activitiesHeader;
        }
        public static List<string> GetActivitiesSummary()
        {
            List<string> activitiesSummary = new List<string>();

            String query = "select activity_summary from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activitysummary = reader["activity_summary"].ToString();
                activitiesSummary.Add(activitysummary);
            }

            reader.Close();

            dbConn.Close();

            return activitiesSummary;
        }

        public static List<string> GetActivitiesLeaders()
        {
            List<string> activitiesLeaders = new List<string>();

            String query = "select activity_leaders from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityleaders = reader["activity_leaders"].ToString();
                activitiesLeaders.Add(activityleaders);
            }

            reader.Close();

            dbConn.Close();

            return activitiesLeaders;
        }
        public static List<string> GetActivitiesSeverity()
        {
            List<string> activitiesSeverity = new List<string>();

            String query = "select activity_severity from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityseverity = reader["activity_severity"].ToString();
                activitiesSeverity.Add(activityseverity);
            }

            reader.Close();

            dbConn.Close();

            return activitiesSeverity;
        }

        public static List<string> GetActivitiesStartDateTime()
        {
            List<string> activitiesStartDateTime = new List<string>();

            String query = "select activity_start_datetime from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activitystart_dateTime = reader["activity_start_datetime"].ToString();
                activitiesStartDateTime.Add(activitystart_dateTime);
            }

            reader.Close();

            dbConn.Close();

            return activitiesStartDateTime;
        }
        public static List<string> GetActivitiesEndDateTime()
        {
            List<string> activitiesEndDateTime = new List<string>();

            String query = "select activity_end_datetime from activities WHERE activity_started=\"Y\";";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String activityend_dateTime = reader["activity_end_datetime"].ToString();
                activitiesEndDateTime.Add(activityend_dateTime);
            }

            reader.Close();

            dbConn.Close();

            return activitiesEndDateTime;
        }


        public static Activity Insert(String header, String summary, Int32 severity, String inserter, String leaders, String startdatetime, String enddatetime, Char started, Char paused, Char stopped)
        {
            String query = string.Format(@"INSERT INTO activities(activity_header, activity_summary, activity_severity, activity_inserter, activity_leaders, activity_start_datetime, activity_end_datetime, activity_started, activity_paused, activity_stopped) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", header, summary, severity, inserter, leaders, startdatetime, enddatetime, started, paused, stopped);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            cmd.ExecuteNonQuery();

            int id = (int)cmd.LastInsertedId;
            Activity activity = new Activity(id, header, summary, severity, inserter, leaders, startdatetime, enddatetime, started, paused, stopped);

            dbConn.Close();

            return activity;

        }
    }
}
