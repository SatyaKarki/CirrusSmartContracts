﻿using Stratis.SmartContracts;

/// <summary>
/// A subset of the ERC20Mintable interface used by OpenZeppelin contracts.
/// For simplicity, we assume that the owner of the contract is the sole minter.
/// </summary>
public interface IMintableWithMetadata
{
    /// <summary>
    /// The owner of the contract can create (mint) new tokens as required.
    /// This increases the total supply of the token.
    /// </summary>
    /// <remarks>Emits a TransferLog event with the 'from' address set to the zero address.</remarks>
    /// <param name="account">The account the newly minted tokens should be credited to.</param>
    /// <param name="amount">The amount of tokens to mint.</param>
    /// <param name="metadata">Additional data to be recorded with the mint.
    /// The structure and interpretation of this data is unspecified here.</param>
    void MintWithMetadata(Address account, UInt256 amount, string metadata);
}
