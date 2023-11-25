﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Button to open a <a href="https://corefork.telegram.org/api/bots/webapps">bot web app</a> using <a href="https://corefork.telegram.org/method/messages.requestSimpleWebView">messages.requestSimpleWebView</a>, without sending user information to the web app.Can only be sent or received as part of a reply keyboard, use <a href="https://corefork.telegram.org/constructor/keyboardButtonWebView">keyboardButtonWebView</a> for inline keyboards.
/// See <a href="https://corefork.telegram.org/constructor/keyboardButtonSimpleWebView" />
///</summary>
[TlObject(0xa0c0505c)]
public sealed class TKeyboardButtonSimpleWebView : IKeyboardButton
{
    public uint ConstructorId => 0xa0c0505c;
    ///<summary>
    /// Button text
    ///</summary>
    public string Text { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/bots/webapps">Web app URL</a>
    ///</summary>
    public string Url { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Text);
        writer.Write(Url);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Text = reader.ReadString();
        Url = reader.ReadString();
    }
}