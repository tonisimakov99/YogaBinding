namespace YogaBinding
{
    internal unsafe class YGConfigApiWindows : IYGConfigApi
    {
        public YGConfig* YGConfigNew()
        {
            return YGConfigApiWindowsNative.YGConfigNew();
        }

        public void YGConfigFree(YGConfig* config)
        {
            YGConfigApiWindowsNative.YGConfigFree(config);
        }

        public YGConfig* YGConfigGetDefault()
        {
            return YGConfigApiWindowsNative.YGConfigGetDefault();
        }

        public void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled)
        {
            YGConfigApiWindowsNative.YGConfigSetUseWebDefaults(config, enabled);
        }

        public bool YGConfigGetUseWebDefaults(YGConfig* config)
        {
            return YGConfigApiWindowsNative.YGConfigGetUseWebDefaults(config);
        }

        public void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint)
        {
            YGConfigApiWindowsNative.YGConfigSetPointScaleFactor(config, pixelsInPoint);
        }

        public float YGConfigGetPointScaleFactor(YGConfig* config)
        {
            return YGConfigApiWindowsNative.YGConfigGetPointScaleFactor(config);
        }

        public void YGConfigSetErrata(YGConfig* config, YGErrata errata)
        {
            YGConfigApiWindowsNative.YGConfigSetErrata(config, errata);
        }

        public YGErrata YGConfigGetErrata(YGConfig* config)
        {
            return YGConfigApiWindowsNative.YGConfigGetErrata(config);
        }

        public void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger)
        {
            YGConfigApiWindowsNative.YGConfigSetLogger(config, logger);
        }

        public void YGConfigSetContext(YGConfig* config, void* context)
        {
            YGConfigApiWindowsNative.YGConfigSetContext(config, context);
        }

        public void* YGConfigGetContext(YGConfig* config)
        {
            return YGConfigApiWindowsNative.YGConfigGetContext(config);
        }

        public void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled)
        {
            YGConfigApiWindowsNative.YGConfigSetExperimentalFeatureEnabled(config, feature, enabled);
        }

        public bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature)
        {
            return YGConfigApiWindowsNative.YGConfigIsExperimentalFeatureEnabled(config, feature);
        }

        public void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback)
        {
            YGConfigApiWindowsNative.YGConfigSetCloneNodeFunc(config, callback);
        }
    }
}