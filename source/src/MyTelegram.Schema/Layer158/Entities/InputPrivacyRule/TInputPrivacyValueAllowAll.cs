﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPrivacyValueAllowAll" />
///</summary>
[TlObject(0x184b35ce)]
public sealed class TInputPrivacyValueAllowAll : IInputPrivacyRule
{
    public uint ConstructorId => 0x184b35ce;


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