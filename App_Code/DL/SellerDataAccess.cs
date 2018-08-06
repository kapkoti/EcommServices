using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SellerDataAccess
/// </summary>
public class SellerDataAccess : CheckNull
{
    public SellerDataAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlParameter[] arrproc;
    clsDataUtility dUT = new clsDataUtility();

    public DataTable GetSellerById(string Id)
    {
        string spName = "Sp_GetSellerById";
        clsDataUtility dUT = new clsDataUtility();
        arrproc = new SqlParameter[1];
        arrproc[0] = new SqlParameter("@SellerId", SqlDbType.Int);
        arrproc[0].Value = CheckNullInt32(Id);
        DataTable dt = new DataTable();
        dt = dUT.getDataTableproc(spName, arrproc);
        return dt;

    }


    public int UpdateSeller(Seller SellerList, string id)
    {
        string spName = "Sp_UpdateSeller";
        clsDataUtility dUT = new clsDataUtility();
        arrproc = new SqlParameter[9];
        arrproc[0] = new SqlParameter("@SellerId", SqlDbType.NVarChar);
        arrproc[0].Value = CheckNullInt32(id);
        arrproc[1] = new SqlParameter("@SellerName", SqlDbType.NVarChar, 20);
        arrproc[1].Value = CheckNullString(SellerList.Sname);
     
        arrproc[2] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
        arrproc[2].Value = CheckNullString(SellerList.Sphone);
        arrproc[3] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
        arrproc[3].Value = CheckNullString(SellerList.Saddress);
        arrproc[4] = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 50);
        arrproc[4].Value = CheckNullString(SellerList.Semail);
        arrproc[5] = new SqlParameter("@", SqlDbType.NVarChar, 50);
        arrproc[5].Value = CheckNullString(SellerList.Susername);
        arrproc[6] = new SqlParameter("@Inactive", SqlDbType.NVarChar, 2);
        arrproc[6].Value = CheckNullInt32(SellerList.Spassword);
        int result = 0;
        result = dUT.ExecuteStoredProc(spName, arrproc);
        return result;
    }

    public int CreateSeller(string Id, string CompanyName, string SellerName, string Address, string City, string State, string Zip, string Country, string Phone, string Email, string active, string English, string Arabic, string Portuguese, string French)
    {
        string spName = "Sp_CreateSeller";
        clsDataUtility dUT = new clsDataUtility();
        arrproc = new SqlParameter[15];
        arrproc[0] = new SqlParameter("@SellerId", SqlDbType.Int);
        arrproc[0].Value = CheckNullInt32(Id);
        arrproc[1] = new SqlParameter("@CompanyName", SqlDbType.VarChar, 50);
        arrproc[1].Value = CheckNullString(CompanyName);
        arrproc[2] = new SqlParameter("@SellerName", SqlDbType.NVarChar, 200);
        arrproc[2].Value = CheckNullString(SellerName);
        arrproc[3] = new SqlParameter("@Address", SqlDbType.NVarChar, 400);
        arrproc[3].Value = CheckNullString(Address);
        arrproc[4] = new SqlParameter("@City", SqlDbType.NVarChar, 100);
        arrproc[4].Value = CheckNullString(City);
        arrproc[5] = new SqlParameter("@State", SqlDbType.NVarChar, 100);
        arrproc[5].Value = CheckNullString(State);
        arrproc[6] = new SqlParameter("@Zip", SqlDbType.VarChar, 10);
        arrproc[6].Value = CheckNullString(Zip);
        arrproc[7] = new SqlParameter("@Country", SqlDbType.NVarChar, 100);
        arrproc[7].Value = CheckNullString(Country);
        arrproc[8] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
        arrproc[8].Value = CheckNullString(Phone);
        arrproc[9] = new SqlParameter("@EmailAddress", SqlDbType.VarChar, 50);
        arrproc[9].Value = CheckNullString(Email);
        arrproc[10] = new SqlParameter("@Inactive", SqlDbType.TinyInt, 2);
        arrproc[10].Value = CheckNullInt32(active);
        arrproc[11] = new SqlParameter("@EnglishLanguage", SqlDbType.Int);
        arrproc[11].Value = CheckNullInt32(English);
        arrproc[12] = new SqlParameter("@ArabicLanguage", SqlDbType.Int);
        arrproc[12].Value = CheckNullInt32(Arabic);
        arrproc[13] = new SqlParameter("@PortugueseLanguage", SqlDbType.Int);
        arrproc[13].Value = CheckNullInt32(Portuguese);
        arrproc[14] = new SqlParameter("@FrenchLanguage", SqlDbType.Int);
        arrproc[14].Value = CheckNullInt32(French);
        int result = 0;
        result = dUT.ExecuteStoredProc(spName, arrproc);
        return result;
    }
}