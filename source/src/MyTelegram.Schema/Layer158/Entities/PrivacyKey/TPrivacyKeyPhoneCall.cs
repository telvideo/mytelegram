﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/privacyKeyPhoneCall" />
///</summary>
[TlObject(0x3d662b7b)]
public sealed class TPrivacyKeyPhoneCall : IPrivacyKey
{
    public uint ConstructorId => 0x3d662b7b;


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