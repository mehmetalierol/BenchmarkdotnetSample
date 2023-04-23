using BenchmarkDotNet.Running;
using TestProject;

//Grpc vs rest 
//_ = BenchmarkRunner.Run<Tester>();

//String concat comparisation
_ = BenchmarkRunner.Run<StringTester>();