using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.slack_clone_server>("slack-clone-server");

builder.Build().Run();
