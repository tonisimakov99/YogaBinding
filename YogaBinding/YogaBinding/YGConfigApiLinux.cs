namespace YogaBinding
{
    internal unsafe class YGConfigApiLinux : IYGConfigApi
    {
        public YGConfig* YGConfigNew()
        {
            return YGConfigApiLinuxNative.YGConfigNew();
        }

        public void YGConfigFree(YGConfig* config)
        {
            YGConfigApiLinuxNative.YGConfigFree(config);
        }

        public YGConfig* YGConfigGetDefault()
        {
            return YGConfigApiLinuxNative.YGConfigGetDefault();
        }

        public void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled)
        {
            YGConfigApiLinuxNative.YGConfigSetUseWebDefaults(config, enabled);
        }

        public bool YGConfigGetUseWebDefaults(YGConfig* config)
        {
            return YGConfigApiLinuxNative.YGConfigGetUseWebDefaults(config);
        }

        public void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint)
        {
            YGConfigApiLinuxNative.YGConfigSetPointScaleFactor(config, pixelsInPoint);
        }

        public float YGConfigGetPointScaleFactor(YGConfig* config)
        {
            return YGConfigApiLinuxNative.YGConfigGetPointScaleFactor(config);
        }

        public void YGConfigSetErrata(YGConfig* config, YGErrata errata)
        {
            YGConfigApiLinuxNative.YGConfigSetErrata(config, errata);
        }

        public YGErrata YGConfigGetErrata(YGConfig* config)
        {
            return YGConfigApiLinuxNative.YGConfigGetErrata(config);
        }

        public void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger)
        {
            YGConfigApiLinuxNative.YGConfigSetLogger(config, logger);
        }

        public void YGConfigSetContext(YGConfig* config, void* context)
        {
            YGConfigApiLinuxNative.YGConfigSetContext(config, context);
        }

        public void* YGConfigGetContext(YGConfig* config)
        {
            return YGConfigApiLinuxNative.YGConfigGetContext(config);
        }

        public void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled)
        {
            YGConfigApiLinuxNative.YGConfigSetExperimentalFeatureEnabled(config, feature, enabled);
        }

        public bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature)
        {
            return YGConfigApiLinuxNative.YGConfigIsExperimentalFeatureEnabled(config, feature);
        }

        public void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback)
        {
            YGConfigApiLinuxNative.YGConfigSetCloneNodeFunc(config, callback);
        }
    }
}