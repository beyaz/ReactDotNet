﻿using System.Text.Json;
using Mono.Cecil;

namespace ReactWithDotNet.ILCodeGeneration;

public static class ILHelper
{
    public static string Deneme2<A,B,C>(string p0, int[] arr = null, int[,,] arr2 = null)
    {
        return "gg";
    }
    
    public static string Deneme(string p0)
    {
        return Deneme2<string, int, int>("g");
        
        //if (p0 == "a")
        //{
        //    try
        //    {
        //        return "a";
        //    }
        //    catch (Exception)
        //    {
        //        return "t";
        //    }
        //}


        //object x = p0;
        //if (x is string)
        //{
        //    Deneme2<string, int, int>("g");
        //}

        //return "b";
    }

    internal static object denemeeee()
    {
        var assemblyDefinition = AssemblyDefinition.ReadAssembly(typeof(ILHelper).Assembly.Location);

        foreach (var moduleDefinition in assemblyDefinition.Modules)
        {
            var typeDefinition = moduleDefinition.GetType("ReactWithDotNet", "ILHelper");
            foreach (var methodDefinition in typeDefinition.Methods)
            {
                if (methodDefinition.Name is "Deneme")
                {
                    var body = methodDefinition.Body.Map();

                    return JsonSerializer.Serialize(body);
                }
            }
        }

        return null;
    }

   

   
    
   
    
    
   

}