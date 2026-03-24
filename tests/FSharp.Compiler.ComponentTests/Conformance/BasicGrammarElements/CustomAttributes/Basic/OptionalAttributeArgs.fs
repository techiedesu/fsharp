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

type SByteAttribute(name : string, value : sbyte) =
    inherit Attribute()
    new([<Optional>] value : sbyte) = SByteAttribute("", value)

type Int16Attribute(name : string, value : int16) =
    inherit Attribute()
    new([<Optional>] value : int16) = Int16Attribute("", value)

type Int64Attribute(name : string, value : int64) =
    inherit Attribute()
    new([<Optional>] value : int64) = Int64Attribute("", value)

type UInt16Attribute(name : string, value : uint16) =
    inherit Attribute()
    new([<Optional>] value : uint16) = UInt16Attribute("", value)

type UInt32Attribute(name : string, value : uint32) =
    inherit Attribute()
    new([<Optional>] value : uint32) = UInt32Attribute("", value)

type UInt64Attribute(name : string, value : uint64) =
    inherit Attribute()
    new([<Optional>] value : uint64) = UInt64Attribute("", value)

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

[<SByte>]
type T7() = class end

[<Int16>]
type T8() = class end

[<Int64>]
type T9() = class end

[<UInt16>]
type T10() = class end

[<UInt32>]
type T11() = class end

[<UInt64>]
type T12() = class end

