using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    //public string GetData(int value)
    //{
    //	return string.Format("You entered: {0}", value);
    //}

    //public CompositeType GetDataUsingDataContract(CompositeType composite)
    //{
    //	if (composite == null)
    //	{
    //		throw new ArgumentNullException("composite");
    //	}
    //	if (composite.BoolValue)
    //	{
    //		composite.StringValue += "Suffix";
    //	}
    //	return composite;
    //}
    public string DeleteSellerData(int id)
    {
        throw new NotImplementedException();
    }

    public Seller GetSellerData(Seller SellerList)
    {
        throw new NotImplementedException();
    }

    public Seller GetSellerDataByID(Seller SellerList, int id)
    {
        throw new NotImplementedException();
    }

    public string SaveSellerData(Seller SellerList)
    {
        throw new NotImplementedException();
    }
}
