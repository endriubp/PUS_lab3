using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServicee1
    {

        public Complex Add(double a_real, double a_imaginary, double b_real, double b_imaginary)
        {
            Complex c = new Complex();
            c.Real = a_real + b_real;
            c.Imaginary = a_imaginary + b_imaginary;
            return c;
        }

        public Complex Divide(double a_real, double a_imaginary, double b_real, double b_imaginary)
        {
            if (b_real == 0 && b_imaginary == 0)
            {

                DivideByZeroException fault = new DivideByZeroException
                {
                    Message = "Cannot divide by zero!",
                    Divided_complex_number = new Complex { Real = a_real, Imaginary = a_imaginary}
                };
                throw new FaultException<DivideByZeroException>(fault, new FaultReason(fault.Message));
            }
            Complex c = new Complex();
            c.Real = ((a_real * b_real) + (a_imaginary * b_imaginary)) / (Math.Pow(b_real, 2) + Math.Pow(b_imaginary, 2));
            c.Imaginary = ((a_imaginary * b_real) - (a_real * b_imaginary)) / (Math.Pow(b_real, 2) + Math.Pow(b_imaginary, 2));
            return c;

        }
        

        public Complex Multiply(double a_real, double a_imaginary, double b_real, double b_imaginary)
        {
            Complex c = new Complex();
            c.Real = (a_real * b_real) - (a_imaginary * b_imaginary);
            c.Imaginary = (a_real * b_imaginary) + (a_imaginary * b_real);
            return c;
        }

        public Complex Substract(double a_real, double a_imaginary, double b_real, double b_imaginary)
        {
            Complex c = new Complex();
            c.Real = a_real - b_real;
            c.Imaginary = a_imaginary - b_imaginary;
            return c;
        }
    }
}
