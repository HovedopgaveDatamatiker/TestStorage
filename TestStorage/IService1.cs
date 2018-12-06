using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestStorage
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //HTTP
        #region COMPONENT

        #region get
        //GET all components
        [OperationContract]
        [WebInvoke(
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "komponenter")
        ]
        List<Component> GetComponents();
        #endregion

        #region post
        //POST component
        [OperationContract]
        [WebInvoke(
                Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                //ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "komponenter")
        ]
        void AddComponent(Component newKomponent);
        #endregion

        #region delete
        //DELETE component
        //[OperationContract]
        //[WebInvoke(
        //        Method = "DELETE",
        //        ResponseFormat = WebMessageFormat.Json,
        //        UriTemplate = "komponenter?id={id}")
        //]
        //void DeleteComponent(int id);
        #endregion

        #endregion

        #region RESERVATION
        //GET all reservations
        [OperationContract]
        [WebInvoke(
                Method = "GET",
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "reservations")
        ]
        List<Reservation> GetReservations();

        //POST new reservation
        [OperationContract]
        [WebInvoke(
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "reservations")]
        void AddReservation(Reservation reservation);

        ////DELETE reservation
        //[OperationContract]
        //[WebInvoke(
        //        Method = "DELETE",
        //        ResponseFormat = WebMessageFormat.Json,
        //        UriTemplate = "reservations?id={id}")
        //]
        //void DeleteReservation(int id);
        #endregion

        #region PRODUCTION
        ////PUT to new in production
        //[OperationContract]
        //[WebInvoke(
        //    Method = "PUT",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "reservation")]
        //void PutToProduction(Reservation reservation);

        ////GET all in production
        //[OperationContract]
        //[WebInvoke(
        //        Method = "GET",
        //        ResponseFormat = WebMessageFormat.Json,
        //        UriTemplate = "production")
        //]
        //List<Reservation> GetAllInProduction();
        #endregion

        #region DONE
        ////GET all done
        //[OperationContract]
        //[WebInvoke(
        //    Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "done")]
        //List<Reservation> GetAllDone();
        #endregion


    }
}
