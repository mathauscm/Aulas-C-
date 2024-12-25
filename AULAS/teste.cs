using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("openpose.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void start();

    static void Main(string[] args)
    {
        start();
        Console.WriteLine("OpenPose started.");
    }
}
