### What?
This app is a TLDR for local and remote forwarding on Windows (way less steps than using PuTTY).

This app is tailored for tunneling to Minecraft servers, but can essentially be used to tunnel any form of network play.

### Why?
Your friends would likely prefer to follow port forward steps from online guides when setting up network play. This is because there is less domain knowledge needed which as a result requires less effort in doing it.

The goal of this app is to encourage a safe and secure option by making it virtually painless to setup a connection. It does this by essentially removing all domain knowledge requirements around TLS and connection tunneling.

### How?
By encapsulating all the configuration values including server address, server port, server user, and RSA private key, and exporting it as an encrypted blob (a Minecraft Key File). The blob is encrypted into a ~1KB file using a provided passphrase and salt value. This file+password pair can then easily be passed around to anyone wanting to connect to the game using the app.

### Is this safe?
Yes, and way safer than port forwarding your routers/servers.

### Credits to asset owners
#### Icons
- [ChrisL21](http://chrisl21.deviantart.com) - http://www.iconarchive.com/artist/chrisl21.html
#### Background
- [Minecraft logo (Mojang/Microsoft)](https://www.minecraft.net/en-us/)
