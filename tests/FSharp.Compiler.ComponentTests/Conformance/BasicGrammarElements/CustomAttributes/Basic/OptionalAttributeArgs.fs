// #Regression #Conformance #DeclarationElements #Attributes
// Regression test for https://github.com/dotnet/fsharp/issues/8353
// Verify that custom attributes with [<Optional>] parameters (no DefaultParameterValue) compile for all value types

open System
open System.Runtime.InteropServices

type BoolAttribute(name : string, flag : bool) =
    inherit Attribute()
    new([<Optional>] flag : bool) = BoolAttribute("", flag)

type IntAttribute(name : string, value : int) =
    inherit Attribute()
    new([<Optional>] value : int) = IntAttribute("", value)

type ByteAttribute(name : string, value : byte) =
    inherit Attribute()
    new([<Optional>] value : byte) = ByteAttribute("", value)

type FloatAttribute(name : string, value : float) =
    inherit Attribute()
    new([<Optional>] value : float) = FloatAttribute("", value)

type SingleAttribute(name : string, value : float32) =
    inherit Attribute()
    new([<Optional>] value : float32) = SingleAttribute("", value)

type CharAttribute(name : string, value : char) =
    inherit Attribute()
    new([<Optional>] value : char) = CharAttribute("", value)

[<Bool>]
type T1() = class end

[<Int>]
type T2() = class end

[<Byte>]
type T3() = class end

[<Float>]
type T4() = class end

[<Single>]
type T5() = class end

[<Char>]
type T6() = class end
