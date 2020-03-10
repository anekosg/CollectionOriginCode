using Core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freamwork
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataset = new DataSet();
            int count = 0;

            using (var db = new DBEFDataContext())
            {
                using (var cmd = db.Database.Connection.CreateCommand())
                {
                    cmd.Parameters.Add(new SqlParameter("@id", 1));
                    cmd.Parameters.Add(new SqlParameter("@name", "name"));
                    cmd.CommandText = "exec proc_GetEmployee @id,@name";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd as SqlCommand);
                    sda.Fill(dataset);

                    if (dataset != null && dataset.Tables.Count > 0 && dataset.Tables[0] != null && dataset.Tables[1] != null)
                    {
                        count = Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
                        Console.WriteLine("数量："+count);
                        var list = dataset.Tables[1].AsEnumerable().Select(x => new
                        {
                            id = x[0]
                        });
                        Console.WriteLine("数据："+list.FirstOrDefault().id);
                    }
                }
            }

            Console.ReadKey();
        }




    }
}
