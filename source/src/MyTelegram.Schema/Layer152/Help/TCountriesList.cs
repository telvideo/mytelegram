﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;


///<summary>
///See <a href="https://core.telegram.org/constructor/help.countriesList" />
///</summary>
[TlObject(0x87d0759e)]
public sealed class TCountriesList : ICountriesList
{
    public uint ConstructorId => 0x87d0759e;
    public TVector<MyTelegram.Schema.Help.ICountry> Countries { get; set; }
    public int Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Countries.Serialize(bw);
        bw.Write(Hash);
    }

    public void Deserialize(BinaryReader br)
    {
        Countries = br.Deserialize<TVector<MyTelegram.Schema.Help.ICountry>>();
        Hash = br.ReadInt32();
    }
}