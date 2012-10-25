@REM This script is run by the Ec2Config service when using Ec2Config
@REM to facilitate running sysprep (via either 'ec2config -sysprep' or
@REM running Sysprep through the Ec2ConfigSettings application).
@REM
@REM The BundleConfig.xml file references this command file.
@REM
@REM You may either insert commands of your choosing here, or direct
@REM the Ec2Config service to use a different command file. By changing
@REM the reference in BundleConfig.xml.  However, Please NOTE:
@REM Some actions that Amazon has placed in here by default
@REM are done so for your host's protection, and should only be 
@REM modified with care.


@REM ****************
@REM Disable further Terminal Service (RDP) connections until re-enabled.
@REM This is to work around the fact that, during the first-boot session 
@REM after Sysprep, there is a brief window where RDP will actually
@REM allow connections *while the Administrator password is blank*.
@REM
@REM This is undesirable, so we have scripted pre-Sysprep and post-
@REM specialize actions to work around this.
@REM
@REM RDP connections are then re-enabled by the SysprepSpecialize.cmd
@REM Script in the Ec2ConfigService\Scripts directory once a random
@REM password has been set by our utilities.

reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server" /v fDenyTSConnections /t REG_DWORD /d 1 /f