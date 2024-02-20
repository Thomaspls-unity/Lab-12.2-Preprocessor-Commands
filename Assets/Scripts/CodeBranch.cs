#define SOME_SYMBOL
#if SOME_SYMBOL
// Symbol is already defined
#else
// Symbol is undefined
#endif

#undef SOME_SYMBOL
#if SOME_SYMBOL
// Symbol is already defined
#else
// Symbol is undefined
#endif

#if UNITY_IOS
    const string dll = "__Internal";
#else
    const string dll = "MyNativePlugin";
#endif

[DllImport(dll)]
private static extern void foo();

#if UNITY_PS4 || UNITY_WII || UNITY_XBOXONE
#define USING_CONSOLE
#endif