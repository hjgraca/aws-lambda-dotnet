﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace TestServerlessApp;

public class GeneratedProgram
{
    private static async Task Main(string[] args)
    {

        switch (Environment.GetEnvironmentVariable("ANNOTATIONS_HANDLER"))
        {
            case "SayHello":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayProxyRequest, Amazon.Lambda.Core.ILambdaContext, Amazon.Lambda.APIGatewayEvents.APIGatewayProxyResponse> sayhello_handler = new TestServerlessApp.Greeter_SayHello_Generated().SayHello;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(sayhello_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;
            case "SayHelloAsync":
                Func<Amazon.Lambda.APIGatewayEvents.APIGatewayProxyRequest, Amazon.Lambda.Core.ILambdaContext, System.Threading.Tasks.Task<Amazon.Lambda.APIGatewayEvents.APIGatewayProxyResponse>> sayhelloasync_handler = new TestServerlessApp.Greeter_SayHelloAsync_Generated().SayHelloAsync;
                await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder.Create(sayhelloasync_handler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer()).Build().RunAsync();
                break;

        }
    }
}