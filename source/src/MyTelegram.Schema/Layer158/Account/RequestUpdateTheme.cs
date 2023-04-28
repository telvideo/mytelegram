﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.updateTheme" />
///</summary>
[TlObject(0x2bf40ccc)]
public sealed class RequestUpdateTheme : IRequest<MyTelegram.Schema.ITheme>
{
    public uint ConstructorId => 0x2bf40ccc;
    public BitArray Flags { get; set; } = new BitArray(32);
    public string Format { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputTheme" />
    ///</summary>
    public MyTelegram.Schema.IInputTheme Theme { get; set; }
    public string? Slug { get; set; }
    public string? Title { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument? Document { get; set; }
    public TVector<MyTelegram.Schema.IInputThemeSettings>? Settings { get; set; }

    public void ComputeFlag()
    {
        if (Slug != null) { Flags[0] = true; }
        if (Title != null) { Flags[1] = true; }
        if (Document != null) { Flags[2] = true; }
        if (Settings?.Count > 0) { Flags[3] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Serialize(Format);
        Theme.Serialize(bw);
        if (Flags[0]) { bw.Serialize(Slug); }
        if (Flags[1]) { bw.Serialize(Title); }
        if (Flags[2]) { Document.Serialize(bw); }
        if (Flags[3]) { Settings.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        Format = br.Deserialize<string>();
        Theme = br.Deserialize<MyTelegram.Schema.IInputTheme>();
        if (Flags[0]) { Slug = br.Deserialize<string>(); }
        if (Flags[1]) { Title = br.Deserialize<string>(); }
        if (Flags[2]) { Document = br.Deserialize<MyTelegram.Schema.IInputDocument>(); }
        if (Flags[3]) { Settings = br.Deserialize<TVector<MyTelegram.Schema.IInputThemeSettings>>(); }
    }
}