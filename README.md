# Simple PlayerPrefs

This is a thin wrapper around the `PlayerPrefs` API by Unity.
As `PlayerPrefs` are not available on all platforms we need a generic wrapper 
that can have different implementations for different platforms.

## API

The API is identical to the Unity API but you need to call `SimplePlayerPrefs` instead of `PlayerPrefs`.