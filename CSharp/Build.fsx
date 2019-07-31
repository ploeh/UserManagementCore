#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.Core.Target //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.DotNet
open Fake.Core

// Targets
Target.create "Build" <| fun _ ->
    "UserManagement.sln"
    |> DotNet.build id

// start build
Target.runOrDefault "Build"
