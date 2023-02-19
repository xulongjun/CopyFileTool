// See https://aka.ms/new-console-template for more information
using ConsoleApp3;

Console.WriteLine("Hello, World!");

var srcLocation = @"C:\Users\xulon\Desktop\RPT";
var destLocation = @"C:\Users\xulon\Desktop\Test\";

var srcLocationFile = @"C:\Users\xulon\Desktop\RPT\DEV\ATHLON_VEG_470 Futures restitutions.rpt";

var destLocationFile = @"C:\Users\xulon\Desktop\Test\DEV\ATHLON_VEG_470 Futures restitutions.rpt";

new Tools().CopyAllFiles(srcLocation, destLocation);

new Tools().CopyOneFile(srcLocationFile, destLocationFile);
