String token = buf.Split(' ')[2];
if (buf.Split(' ')[1] == "CAP")
{
//Printing our current session token
Console.Write("Token=" + token + "\n");

//Stage 1 AUTHENTICATION
if (buf.Split(' ')[1] == "CAP" && buf.Split(' ')[2] == token && buf.Split(' ')[3] == "LS")
{
output.Write("CAP REQ :multi-prefix " + "\r\n");
Console.Write("Client: CAP REQ :multi-prefix SENT" + "\n");
}
else if (buf.Split(' ')[1] == "CAP" && buf.Split(' ')[2] == nick)
{
output.Write("CAP END " + "\r\n");
Console.Write("Client: CAP END SENT" + "\n");
} 
output.Flush();
}
//Sending the "version signature" back to the server
if (buf.Split(' ')[1] == "PRIVMSG")
{
output.Write("NOTICE x01.mirc.com.gr : VERSION mIRC v7.43 ");
Console.Write("Client: PRIVMSG VERSION SENT" + "\n");
output.Flush();
}
