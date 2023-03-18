namespace Org.BouncyCastle.Bcpg
{
    /// <summary>Basic PGP signature sub-packet tag types.</summary>
    /// <remarks>
    /// <para>
    /// NOTE: Subpacket types outside of what is defined in this Enum are possible.
    /// Use <see cref="System.Enum.IsDefined{TEnum}(TEnum)"/> to confirm.<br/>
    /// An implementation SHOULD ignore any subpacket of a type that it does not recognize,
    /// unless <see cref="SignatureSubpacket.IsCritical"/> is <see langword="true"/>,
    /// in which case the evaluator SHOULD consider the signature to be in error.
    /// </para>
    /// <para>Defined in <see href="https://www.rfc-editor.org/rfc/rfc4880#section-5.2.3.1">RFC4880, section 5.2.3.1</see>.</para>
    /// </remarks>
    public enum SignatureSubpacketTag
    {
        /// <summary>Signature creation time</summary>
        CreationTime = 2,

        /// <summary>Signature expiration time</summary>
        ExpireTime = 3,

        /// <summary>Exportable certification</summary>
        Exportable = 4,

        /// <summary>Trust signature</summary>
        TrustSig = 5,

        /// <summary>Regular expression</summary>
        RegExp = 6,

        /// <summary>Revocable</summary>
        Revocable = 7,

        /// <summary>Key expiration time</summary>
        KeyExpireTime = 9,

        /// <summary>Placeholder for backward compatibility</summary>
        Placeholder = 10,

        /// <summary>Preferred symmetric algorithms</summary>
        PreferredSymmetricAlgorithms = 11,

        /// <summary>Revocation key</summary>
        RevocationKey = 12,

        /// <summary>Issuer key ID</summary>
        IssuerKeyId = 16,

        /// <summary>Notation data</summary>
        NotationData = 20,

        /// <summary>Preferred hash algorithms</summary>
        PreferredHashAlgorithms = 21,

        /// <summary>Preferred compression algorithms</summary>
        PreferredCompressionAlgorithms = 22,

        /// <summary>Key server preferences</summary>
        KeyServerPreferences = 23,

        /// <summary>Preferred key server</summary>
        PreferredKeyServer = 24,

        /// <summary>Primary user id</summary>
        PrimaryUserId = 25,

        /// <summary>Policy URI</summary>
        PolicyUrl = 26,

        /// <summary>Key flags</summary>
        KeyFlags = 27,

        /// <summary>Signer's user id</summary>
        SignerUserId = 28,

        /// <summary>Reason for revocation</summary>
        RevocationReason = 29,

        /// <summary>Features</summary>
        Features = 30,

        /// <summary>Signature target</summary>
        SignatureTarget = 31,

        /// <summary>Embedded signature</summary>
        EmbeddedSignature = 32,

        /// <summary>Issuer key fingerprint</summary>
        IssuerFingerprint = 33,

        //PreferredAeadAlgorithms = 34,         // RESERVED since crypto-refresh-05

        /// <summary>Intended recipient fingerprint</summary>
        IntendedRecipientFingerprint = 35,

        /// <summary>(RESERVED) Attested certifications</summary>
        AttestedCertifications = 37,

        /// <summary>(RESERVED) Key Block</summary>
        KeyBlock = 38,

        /// <summary>Preferred AEAD algorithms</summary>
        PreferredAeadAlgorithms = 39,
    }
}
