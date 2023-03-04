﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.recentStickers" />
///</summary>
[TlObject(0x88d37c56)]
public sealed class TRecentStickers : IRecentStickers
{
    public uint ConstructorId => 0x88d37c56;
    public long Hash { get; set; }
    public TVector<MyTelegram.Schema.IStickerPack> Packs { get; set; }
    public TVector<MyTelegram.Schema.IDocument> Stickers { get; set; }
    public TVector<int> Dates { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Hash);
        Packs.Serialize(bw);
        Stickers.Serialize(bw);
        Dates.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Hash = br.ReadInt64();
        Packs = br.Deserialize<TVector<MyTelegram.Schema.IStickerPack>>();
        Stickers = br.Deserialize<TVector<MyTelegram.Schema.IDocument>>();
        Dates = br.Deserialize<TVector<int>>();
    }
}