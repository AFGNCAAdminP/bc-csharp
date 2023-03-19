namespace Org.BouncyCastle.Bcpg
{

    /// <summary>Basic tags for symmetric key algorithms</summary>
    public enum SymmetricKeyAlgorithmTag
    {
        /// <summary>Plaintext or unencrypted data.</summary>
        Null = 0,

        /// <summary>International Data Encryption Algorithm (IDEA).</summary>
        Idea = 1,

        /// <summary>TripleDES (DES-EDE, 168 bit key derived from 192).</summary>
        TripleDes = 2,

        /// <summary>CAST5 (128 bit key, as per RFC 2144).</summary>
        Cast5 = 3,

        /// <summary>Blowfish (128 bit key, 16 rounds).</summary>
        /// <seealso href="https://www.schneier.com/academic/blowfish/">The Blowfish Encryption Algorithm</seealso>
        Blowfish = 4,

        /// <summary>Secure And Fast Encryption Routine, Strengthened Key schedule, 128-bits (SAFER SK-128) (13 rounds).</summary>
        Safer = 5,

        /// <summary>Data Encryption Standard, Strengthened Key schedule (DES/SK).</summary>
        /// <seealso href="https://www.cs.columbia.edu/~smb/papers/ides.pdf">A Better Key Schedule for DES-like Ciphers</seealso>
        Des = 6,

        /// <summary>Advanced Encryption Standard (AES) with 128-bit key.</summary>
        Aes128 = 7,

        /// <summary>Advanced Encryption Standard (AES) with 192-bit key.</summary>
        Aes192 = 8,

        /// <summary>Advanced Encryption Standard (AES) with 256-bit key.</summary>
        Aes256 = 9,

        /// <summary>Twofish with 256-bit key.</summary>
        /// <seealso href="https://www.schneier.com/academic/twofish/">Twofish</seealso>
        Twofish = 10,

        /// <summary>Camellia with 128-bit key.</summary>
        Camellia128 = 11,

        /// <summary>Camellia with 192-bit key.</summary>
        Camellia192 = 12,

        /// <summary>Camellia with 256-bit key.</summary>
        Camellia256 = 13
    }
}
