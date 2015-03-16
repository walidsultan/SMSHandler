using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMSServer.DataMapping;

namespace SMSServer.DataAccessLayer
{
   public  class DestinationsManager
    {
       public Destination GetDestinationById(int id)
       {
           DcSMSOut dbSMS = new DcSMSOut();
           return dbSMS.Destinations.SingleOrDefault(d => d.Id == id);
       }

       public List<Destination> GetAllDestinations()
       {
           DcSMSOut dbSMS = new DcSMSOut();
           return dbSMS.Destinations.ToList();
       }

       public Destination GetDestinationByName(string name)
       {
           DcSMSOut dbSMS = new DcSMSOut();
           return dbSMS.Destinations.SingleOrDefault (d =>d.Name==name);
       }

       public void UpdateDestination(Destination destination)
       {
           DcSMSOut dbSMS = new DcSMSOut();
           Destination exisitingDestination = dbSMS.Destinations.SingleOrDefault(d => d.Id == destination.Id);
           exisitingDestination.Name = destination.Name;
           dbSMS.SubmitChanges();
       }

       public int InsertDestination(Destination  destination)
       {
           DcSMSOut dbSMS = new DcSMSOut();
           dbSMS.Destinations.InsertOnSubmit(destination);
           dbSMS.SubmitChanges();
           return destination.Id;
       }

       public void DeleteDestination(int  destinationId)
       {
           DcSMSOut dbSMS = new DcSMSOut();
           Destination existingDestination = dbSMS.Destinations.Single(d => d.Id == destinationId);
           dbSMS.Destinations.DeleteOnSubmit(existingDestination);
           dbSMS.SubmitChanges();
       }
    }
}
