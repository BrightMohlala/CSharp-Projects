using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Ct6Q3v2_Memento
{
    internal class DBhelper : IDB
    {
        private SqliteConnection cn;

        #region Creation

        private DBhelper()
        {
            string cnString = "Data Source = Orders.db; Cache=Shared";
            cn = new SqliteConnection(cnString);
            cn.Open();
        } //ctor

        //Singleton members
        private static DBhelper _instance;
        private static readonly object _lock = new object();

        public static DBhelper GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) 
                {
                    if (_instance == null) 
                        _instance = new DBhelper();
                } //Release the lock
            }

            return _instance;
        } //GetInstance

        #endregion Creation

        public List<Item> GetItems()
        {
            string sql = "SELECT id, item_name, quantity FROM Items ORDER BY item_name";
            List<Item> items = new List<Item>();
            using (SqliteCommand cmd = new SqliteCommand(sql, cn))
            {
                SqliteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Item item = new Item(rdr["item_name"].ToString(), (int)(long)rdr["quantity"], (int)(long)rdr["id"]);
                    items.Add(item);
                } //while
            } //using
            return items;
        } //GetItems

        //public Item GetItem(int id)
        //{
        //    string sql = "SELECT id, item_name, quantity FROM Items WHERE id = @id";
        //    using (SqliteCommand cmd = new SqliteCommand(sql, cn))
        //    {
        //        cmd.Parameters.AddWithValue("@id", id);
        //        SqliteDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //            return new Item(rdr["item_name"].ToString(), (int)(long)rdr["Quantity"], (int)(long)rdr["id"]);
        //    } //using
        //    return null;
        //} //GetItem

        public void AddItem(Item item)
        {
            string sql = "INSERT INTO Items (item_name, quantity) VALUES (@item_name, @quantity)";
            using (SqliteCommand cmd = new SqliteCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@item_name", item.Name);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.ExecuteNonQuery();
            }
        } //AddItem

        public void UpdateItem(Item item)
        {
            using var cmd = new SqliteCommand("UPDATE Items SET item_name = @item_name, Quantity = @qty WHERE id = @id", cn);
            cmd.Parameters.AddWithValue("@item_name", item.Name);
            cmd.Parameters.AddWithValue("@qty", item.Quantity);
            cmd.Parameters.AddWithValue("@id", item.id);
            cmd.ExecuteNonQuery();
        } //EditItem

        public void DeleteItem(int id)
        {
            using var cmd = new SqliteCommand("DELETE FROM Items WHERE id = @id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        } //DeleteItem

    } //DBHelper
} //namespace
