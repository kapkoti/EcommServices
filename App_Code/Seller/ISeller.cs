using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	// Save and Update Data
	[OperationContract]
	string SaveSellerData(Seller SellerList);

    //Select All Seller Data
    [OperationContract]
    Seller GetSellerData(Seller SellerList);

    // Select Seler Data using ID
    [OperationContract]
    Seller GetSellerDataByID(Seller SellerList, int id);

    // Delete Seller Data
    [OperationContract]
    string DeleteSellerData(int id);


    // TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Seller
{
	string name ;
    string phone;
    string email;
    string address;
    string username;
    string password;
    string id;


    [DataMember]
    public string Sid
    {
        get { return id; }
        set { id = value; }
    }

    [DataMember]
	public string Sname
	{
		get { return name; }
		set { name = value; }
	}

	[DataMember]
	public string Semail
	{
		get { return email; }
		set { email = value; }
	}

    [DataMember]
    public string Sphone
    {
        get { return phone; }
        set { phone = value; }
    }

    [DataMember]
    public string Saddress
    {
        get { return address; }
        set { address = value; }
    }

    [DataMember]
    public string Susername
    {
        get { return username; }
        set { username = value; }
    }

    [DataMember]
    public string Spassword
    {
        get { return password; }
        set { password = value; }
    }
}
