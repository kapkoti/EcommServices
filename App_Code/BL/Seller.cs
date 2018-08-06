using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Seller
/// </summary>
public class BLSeller
{
    Seller objSeller = new Seller();
   
    SellerDataAccess objDl = new SellerDataAccess();
    public BLSeller()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable GetSellerById(string Id)
    {
        DataTable dt = new DataTable();
        dt = objDl.GetSellerById(Id);
        return dt;

    }
    public int UpdateSeller()
    {
        int result = objDl.UpdateSeller(objSeller.Susername,objSeller.Semail,objSeller.Sname,objSeller.Spassword,objSeller.Sphone,objSeller.Susername,objSeller.Sid);
        return result;
    }
    public int CreateSeller(string Id, string CompanyName, string SellerName, string Address, string City, string State, string Zip, string Country, string Phone, string Email, string active, string English, string Arabic, string Portuguese, string French)
    {
        int result = objDl.CreateSeller(Id, CompanyName, SellerName, Address, City, State, Zip, Country, Phone, Email, active, English, Arabic, Portuguese, French);
        return result;
    }


}