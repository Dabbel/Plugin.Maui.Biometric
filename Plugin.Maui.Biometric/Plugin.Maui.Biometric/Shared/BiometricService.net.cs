﻿namespace Plugin.Maui.Biometric;
#if NET && !ANDROID && !IOS
internal partial class BiometricService : IBiometric
{
    public partial Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public partial Task<BiometricHwStatus> GetAuthenticationStatusAsync(AuthenticatorStrength authStrength)
    {
        throw new NotImplementedException();
    }

    public partial Task<BiometricType> GetEnrolledBiometricTypeAsync()
    {
        throw new NotImplementedException();
    }
}
#endif