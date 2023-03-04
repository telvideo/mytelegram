﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputThemeSettings" />
///</summary>
[TlObject(0x8fde504f)]
public sealed class TInputThemeSettings : IInputThemeSettings
{
    public uint ConstructorId => 0x8fde504f;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool MessageColorsAnimated { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/BaseTheme" />
    ///</summary>
    public MyTelegram.Schema.IBaseTheme BaseTheme { get; set; }
    public int AccentColor { get; set; }
    public int? OutboxAccentColor { get; set; }
    public TVector<int>? MessageColors { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputWallPaper" />
    ///</summary>
    public MyTelegram.Schema.IInputWallPaper? Wallpaper { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/WallPaperSettings" />
    ///</summary>
    public MyTelegram.Schema.IWallPaperSettings? WallpaperSettings { get; set; }

    public void ComputeFlag()
    {
        if (MessageColorsAnimated) { Flags[2] = true; }
        if (OutboxAccentColor != 0 && OutboxAccentColor.HasValue) { Flags[3] = true; }
        if (MessageColors?.Count > 0) { Flags[0] = true; }
        if (Wallpaper != null) { Flags[1] = true; }
        if (WallpaperSettings != null) { Flags[1] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        BaseTheme.Serialize(bw);
        bw.Write(AccentColor);
        if (Flags[3]) { bw.Write(OutboxAccentColor.Value); }
        if (Flags[0]) { MessageColors.Serialize(bw); }
        if (Flags[1]) { Wallpaper.Serialize(bw); }
        if (Flags[1]) { WallpaperSettings.Serialize(bw); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[2]) { MessageColorsAnimated = true; }
        BaseTheme = br.Deserialize<MyTelegram.Schema.IBaseTheme>();
        AccentColor = br.ReadInt32();
        if (Flags[3]) { OutboxAccentColor = br.ReadInt32(); }
        if (Flags[0]) { MessageColors = br.Deserialize<TVector<int>>(); }
        if (Flags[1]) { Wallpaper = br.Deserialize<MyTelegram.Schema.IInputWallPaper>(); }
        if (Flags[1]) { WallpaperSettings = br.Deserialize<MyTelegram.Schema.IWallPaperSettings>(); }
    }
}