# Unexpected Behavior in F# Mutable Variable Swap

This repository demonstrates an unexpected behavior when swapping mutable variables in F# using a helper function.  The issue arises from how mutable variables are handled within nested scopes and functions when passed by reference.

## Problem Description

The `swap` function correctly swaps two mutable variables. However, the `swap2` function, which attempts a similar swap using a helper function, fails to modify the original variables, resulting in unexpected output.

## Solution

The solution involves returning the modified values from the helper function, thereby ensuring that the original variables are updated correctly.  This illustrates the importance of understanding how mutability and references work within the scope of functions in F#.