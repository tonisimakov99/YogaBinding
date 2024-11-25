namespace YogaBinding
{
    public unsafe class YGConfigApi
    {
        public YGConfigApi(Platform platform)
        {
            if (platform == Platform.Windows)
                lib = new YGConfigApiWindows();
            else if (platform == Platform.Linux)
                lib = new YGConfigApiLinux();
            else if (platform == Platform.Android)
                lib = new YGConfigApiAndroid();
            else
                throw new System.NotSupportedException("not supported");
        }

        IYGConfigApi lib;
        public YGConfig* YGConfigNew()
        {
            return lib.YGConfigNew();
        }

        public void YGConfigFree(YGConfig* config)
        {
            lib.YGConfigFree(config);
        }

        public YGConfig* YGConfigGetDefault()
        {
            return lib.YGConfigGetDefault();
        }

        public void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled)
        {
            lib.YGConfigSetUseWebDefaults(config, enabled);
        }

        public bool YGConfigGetUseWebDefaults(YGConfig* config)
        {
            return lib.YGConfigGetUseWebDefaults(config);
        }

        public void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint)
        {
            lib.YGConfigSetPointScaleFactor(config, pixelsInPoint);
        }

        public float YGConfigGetPointScaleFactor(YGConfig* config)
        {
            return lib.YGConfigGetPointScaleFactor(config);
        }

        public void YGConfigSetErrata(YGConfig* config, YGErrata errata)
        {
            lib.YGConfigSetErrata(config, errata);
        }

        public YGErrata YGConfigGetErrata(YGConfig* config)
        {
            return lib.YGConfigGetErrata(config);
        }

        public void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger)
        {
            lib.YGConfigSetLogger(config, logger);
        }

        public void YGConfigSetContext(YGConfig* config, void* context)
        {
            lib.YGConfigSetContext(config, context);
        }

        public void* YGConfigGetContext(YGConfig* config)
        {
            return lib.YGConfigGetContext(config);
        }

        public void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled)
        {
            lib.YGConfigSetExperimentalFeatureEnabled(config, feature, enabled);
        }

        public bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature)
        {
            return lib.YGConfigIsExperimentalFeatureEnabled(config, feature);
        }

        public void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback)
        {
            lib.YGConfigSetCloneNodeFunc(config, callback);
        }
    }
}