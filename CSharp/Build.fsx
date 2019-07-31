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

Target.create "Test" <| fun _ ->
    "UserManagement.sln"
    |> DotNet.test id

// Dependencies
open Fake.Core.TargetOperators
"Build"
==> "Test"

// start build
Target.runOrDefault "Test"