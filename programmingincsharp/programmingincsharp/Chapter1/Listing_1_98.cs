using System;
using System.Runtime.Serialization;

namespace Chapter1
{
    [Serializable]
    public class OrderProcessException : Exception, ISerializable
    {
        public OrderProcessException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        public OrderProcessException(int orderId, string message) : base(message)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        public OrderProcessException(int orderId, string message, Exception innerException) : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        protected OrderProcessException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
        }
        public int OrderId { get; private set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OrderId", OrderId, typeof(int));
        }
    }
}