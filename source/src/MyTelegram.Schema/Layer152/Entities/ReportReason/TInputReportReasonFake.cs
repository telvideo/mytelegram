﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputReportReasonFake" />
///</summary>
[TlObject(0xf5ddd6e7)]
public sealed class TInputReportReasonFake : IReportReason
{
    public uint ConstructorId => 0xf5ddd6e7;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}