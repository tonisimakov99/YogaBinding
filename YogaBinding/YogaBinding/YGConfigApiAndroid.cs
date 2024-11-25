namespace YogaBinding
{
    internal unsafe class YGConfigApiAndroid : IYGConfigApi
    {
        public YGConfig* YGConfigNew()
        {
            return YGConfigApiAndroidNative.YGConfigNew();
        }

        public void YGConfigFree(YGConfig* config)
        {
            YGConfigApiAndroidNative.YGConfigFree(config);
        }

        public YGConfig* YGConfigGetDefault()
        {
            return YGConfigApiAndroidNative.YGConfigGetDefault();
        }

        public void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled)
        {
            YGConfigApiAndroidNative.YGConfigSetUseWebDefaults(config, enabled);
        }

        public bool YGConfigGetUseWebDefaults(YGConfig* config)
        {
            return YGConfigApiAndroidNative.YGConfigGetUseWebDefaults(config);
        }

        public void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint)
        {
            YGConfigApiAndroidNative.YGConfigSetPointScaleFactor(config, pixelsInPoint);
        }

        public float YGConfigGetPointScaleFactor(YGConfig* config)
        {
            return YGConfigApiAndroidNative.YGConfigGetPointScaleFactor(config);
        }

        public void YGConfigSetErrata(YGConfig* config, YGErrata errata)
        {
            YGConfigApiAndroidNative.YGConfigSetErrata(config, errata);
        }

        public YGErrata YGConfigGetErrata(YGConfig* config)
        {
            return YGConfigApiAndroidNative.YGConfigGetErrata(config);
        }

        public void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger)
        {
            YGConfigApiAndroidNative.YGConfigSetLogger(config, logger);
        }

        public void YGConfigSetContext(YGConfig* config, void* context)
        {
            YGConfigApiAndroidNative.YGConfigSetContext(config, context);
        }

        public void* YGConfigGetContext(YGConfig* config)
        {
            return YGConfigApiAndroidNative.YGConfigGetContext(config);
        }

        public void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled)
        {
            YGConfigApiAndroidNative.YGConfigSetExperimentalFeatureEnabled(config, feature, enabled);
        }

        public bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature)
        {
            return YGConfigApiAndroidNative.YGConfigIsExperimentalFeatureEnabled(config, feature);
        }

        public void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback)
        {
            YGConfigApiAndroidNative.YGConfigSetCloneNodeFunc(config, callback);
        }
    }
}