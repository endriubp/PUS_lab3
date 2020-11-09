using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicee1
    {

        [OperationContract]
        Complex Add(double a_real, double a_imaginary, double b_real, double b_imaginary);

        [OperationContract]
        Complex Multiply(double a_real, double a_imaginary, double b_real, double b_imaginary);

        [OperationContract]
        Complex Substract(double a_real, double a_imaginary, double b_real, double b_imaginary);

        [OperationContract]
        [FaultContract(typeof(DivideByZeroException))]
        Complex Divide(double a_real, double a_imaginary, double b_real, double b_imaginary);



        // TODO: Add your service operations here
    }

    [DataContract]
    public class DivideByZeroException
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public Complex Divided_complex_number { get; set; }
 

    }


    [DataContract]
    public class Complex
    {
        double real;
        double imaginary;

        [DataMember]
        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        [DataMember]
        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
