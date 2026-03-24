module ErrorMessages.DiagnosticRegressionTests

open Xunit
open FSharp.Test.Compiler

// https://github.com/dotnet/fsharp/issues/10043
[<Fact>]
let ``Issue 10043 - backtick in type annotation should not report unexpected keyword`` () =
    FSharp
        """
let i:float`1 = 3.0
        """
    |> typecheck
    |> shouldFail
    |> withDiagnostics
        [ (Error 3563, Line 2, Col 12, Line 2, Col 13, "This is not a valid identifier")
          (Error 10, Line 2, Col 13, Line 2, Col 14, "Unexpected integer literal in binding. Expected '=' or other token.") ]

// https://github.com/dotnet/fsharp/issues/10043
[<Fact>]
let ``Issue 10043 - at sign in type annotation should report infix operator`` () =
    FSharp
        """
let i:float@1 = 3.0
        """
    |> typecheck
    |> shouldFail
    |> withDiagnostics
        [ (Error 615, Line 2, Col 12, Line 2, Col 13, "Unexpected infix operator in type expression") ]

// https://github.com/dotnet/fsharp/issues/10043
[<Fact>]
let ``Issue 10043 - bang in type annotation should report reserved identifier`` () =
    FSharp
        """
let i:float!1 = 3.0
        """
    |> typecheck
    |> shouldFail
    |> withDiagnostics
        [ (Error 1141, Line 2, Col 7, Line 2, Col 13, "Identifiers followed by '!' are reserved for future use")
          (Error 10, Line 2, Col 13, Line 2, Col 14, "Unexpected integer literal in binding. Expected '=' or other token.") ]
