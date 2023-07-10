using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace BusAllocationSystem
{
    public class dbUtil
    {
        public String insertUser(String firstName, String lastName, String emailAddress, String Address, String pwd)
        {
            String resp = "";
            try
            {
                DateTime datevar = DateTime.Now;
                String dt = datevar.ToString("yyyy-MM-dd hh:mm");

                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_InsertUser";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pFirstName", firstName);
                        cmd.Parameters.AddWithValue("@pLastName", lastName);
                        cmd.Parameters.AddWithValue("@pEmailAddress", emailAddress);
                        cmd.Parameters.AddWithValue("@pAddress", Address);
                        cmd.Parameters.AddWithValue("@ppwd", pwd);
                        cmd.Parameters.AddWithValue("@pDateCreated", dt);

                        con.Open();

                        int ret = cmd.ExecuteNonQuery();
                        resp = "SUCCESSFUL";
                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                if(ex.Message.Contains("duplicate"))
                {
                    resp = "USER ALREADY EXISTS";
                }
                else
                {
                    resp = ex.Message;
                }

                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }
        public String insertBus(String tagid, String regno, String seatNo, String username)
        {
            String resp = "";
           
            try
            {
                DateTime datevar = DateTime.Now;
                String dt = datevar.ToString("yyyy-MM-dd hh:mm");

                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_InsertBus";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@ptag", tagid);
                        cmd.Parameters.AddWithValue("@pregno", regno);
                        cmd.Parameters.AddWithValue("@seatNo", seatNo);
                        cmd.Parameters.AddWithValue("@pmakeId", username);
                        cmd.Parameters.AddWithValue("@pDateCreated", dt);

                        con.Open();

                        int ret = cmd.ExecuteNonQuery();
                        resp = "SUCCESSFUL";
                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                if(ex.Message.Contains("duplicate"))
                {
                    resp = "BUS ALREADY EXISTS";
                }
                else
                {
                    resp = ex.Message;
                }

                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }
         public String insertBusstop(String busstop, String stateName, String username)
        {
            String resp = "";
            try
            {
                DateTime datevar = DateTime.Now;
                String dt = datevar.ToString("yyyy-MM-dd hh:mm");

                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_InsertBusstop";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pbusstop", busstop);
                        cmd.Parameters.AddWithValue("@pStateName", stateName);
                        cmd.Parameters.AddWithValue("@pmakeId", username);
                        cmd.Parameters.AddWithValue("@pDateCreated", dt);

                        con.Open();

                        int ret = cmd.ExecuteNonQuery();
                        resp = "SUCCESSFUL";
                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                if(ex.Message.Contains("duplicate"))
                {
                    resp = "BUS STOP ALREADY EXISTS";
                }
                else
                {
                    resp = ex.Message;
                }

                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }
         public String insertBusstopAllocation(String bus, String busStop, String username)
        {
            String resp = "";
            try
            {
                DateTime datevar = DateTime.Now;
                String dt = datevar.ToString("yyyy-MM-dd hh:mm");

                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_InsertBusstopAllocation";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pbus", bus);
                        cmd.Parameters.AddWithValue("@pbusStop", busStop);
                        cmd.Parameters.AddWithValue("@pmakeId", username);
                        cmd.Parameters.AddWithValue("@pDateCreated", dt);

                        con.Open();

                        int ret = cmd.ExecuteNonQuery();
                        resp = "SUCCESSFUL";
                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                    resp = ex.Message;
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }

        public String updateUserBus(String bus, String busStop, String username)
        {
            String resp = "";
            try
            {
                DateTime datevar = DateTime.Now;
                String dt = datevar.ToString("yyyy-MM-dd hh:mm");

                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_UpdateUserBus";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pbus", bus);
                        cmd.Parameters.AddWithValue("@pbusStop", busStop);
                        cmd.Parameters.AddWithValue("@pmakeId", username);
                        cmd.Parameters.AddWithValue("@pDateCreated", dt);

                        con.Open();

                        int ret = cmd.ExecuteNonQuery();
                        resp = "SUCCESSFUL";
                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {              
                    resp = ex.Message;
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }

        public userDto fetchUser(String emailAddress)
        {
            userDto resp = new userDto();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_fetchUser";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pEmailAddress", emailAddress);

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            resp.address = dr["address"].ToString();
                            resp.busNumber = dr["busNumber"].ToString();
                            resp.busStop = dr["busstop"].ToString(); ;
                            resp.emailAddress = dr["email"].ToString();
                            resp.firstName = dr["first_name"].ToString();
                            resp.lastName = dr["last_name"].ToString();
                            resp.userId = dr["user_id"].ToString();
                            resp.pwd = dr["pwd"].ToString();
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }

            return resp;
        }

        public List<userDto> fetchUsers()
        {
            List<userDto> resp2 = new List<userDto>();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_fetchUsers";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            userDto resp = new userDto();
                            resp.address = dr["address"].ToString();
                            resp.busNumber = dr["busNumber"].ToString();
                            resp.busStop = dr["busstop"].ToString(); ;
                            resp.emailAddress = dr["email"].ToString();
                            resp.firstName = dr["first_name"].ToString();
                            resp.lastName = dr["last_name"].ToString();
                            resp.userId = dr["user_id"].ToString();
                            resp.DateCreated = dr["created_at"].ToString();
                            resp.DateUpdated = dr["DateUpdated"].ToString();

                            resp2.Add(resp);
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }


        public List<busDto> fetchBuses()
        {
            List<busDto> resp2 = new List<busDto>();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_fetchBuses";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            busDto resp = new busDto();
                            resp.tagId = dr["tag"].ToString();
                            resp.regNo = dr["reg_no"].ToString();
                            resp.totalSeat = dr["totalSeat"].ToString();
                            resp.takenSeat = dr["takenSeat"].ToString();
                            resp.makerId = dr["makerId"].ToString(); ;
                            resp.makeStamp = dr["makerStamp"].ToString();

                            resp2.Add(resp);
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }

        public List<busDto> fetchBusesByBusStop(String bustStop)
        {
            List<busDto> resp2 = new List<busDto>();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_fetchBusesByBusStop";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@pbusStop", bustStop);

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            busDto resp = new busDto();
                            resp.regNo = dr["busRegno"].ToString();
                            resp.makerId = dr["makerId"].ToString(); ;
                            resp.makeStamp = dr["makerStamp"].ToString();

                            resp2.Add(resp);
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }


        public List<busStopDto> fetchBusStop()
        {
            List<busStopDto> resp2 = new List<busStopDto>();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_fetchBusstop";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            busStopDto resp = new busStopDto();
                            resp.busStop = dr["busstop"].ToString();
                            resp.stateName = dr["stateName"].ToString();
                            resp.makerId = dr["makerId"].ToString(); ;
                            resp.makeStamp = dr["makerStamp"].ToString();

                            resp2.Add(resp);
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
              new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
              new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }
        public dataCounterDto fetchCounts()
        {
            dataCounterDto resp2 = new dataCounterDto();
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "proc_countData";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dataCounterDto resp = new dataCounterDto();
                            resp.countUsers = dr["countUsers"].ToString();
                            resp.countBuses = dr["countBuses"].ToString();
                            resp.countBusStops = dr["countBusStops"].ToString(); ;
                            resp.countAvailableBuses = dr["countAvailableBuses"].ToString();
                            resp.countOccupiedBuses = dr["countOccupiedBuses"].ToString();
                            resp.countDrivers = dr["countDrivers"].ToString();

                            resp2 = resp;
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
                    }
            catch(Exception ex)
            {
              new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
              new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }


        public String fetchUserRole(String userId)
        {
            String resp2 = "";
            try
            {
                string constr = WebConfigurationManager.ConnectionStrings["dbbap"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        String getsql = "Proc_roleFetcher";

                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = getsql;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@puserid", userId);

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            resp2 = dr["roleid"].ToString();
                        }

                        con.Dispose();
                        con.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                new Util().WriteToFile("ERROR: " + ex.Message + " " + DateTime.Now);
                new Util().WriteToFile("ERROR: " + ex.StackTrace + " " + DateTime.Now);
            }
            return resp2;
        }

    }
}