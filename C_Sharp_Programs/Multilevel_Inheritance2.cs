using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Programs
{
    public interface IPhone
    {
        void MakeCall(string number, int duration);
        void SendSMS(string number, string message);
    }

    public interface ICamera
    {
        void TakePhoto(string mode, int resolution);
        void RecordVideo(string format, int duration);
    }
    public class Smartphone : IPhone, ICamera
    {
        public void MakeCall(string number, int duration)
        {
            Console.WriteLine($"Making a call to {number} for {duration} minutes.");
        }
        public void SendSMS(string number, string message)
        {
            Console.WriteLine($"Sending SMS to {number}: {message}");
        }
        public void TakePhoto(string mode, int resolution)
        {
            Console.WriteLine($"Taking a photo in {mode} mode with {resolution}MP resolution.");
        }
        public void RecordVideo(string format, int duration)
        {
            Console.WriteLine($"Recording a video in {format} format for {duration} minutes.");
        }
    }
    internal class Multilevel_Inheritance2
    {
        static void Main(string[] args)

        {
            Smartphone s1 = new Smartphone();
            s1.MakeCall("123-456-7890", 5);
            s1.SendSMS("123-456-7890", "Hello, this is a test message");
            s1.TakePhoto("Portrait", 12);
            s1.RecordVideo("MP4", 5);
            Console.ReadLine();
        }
    }
}
