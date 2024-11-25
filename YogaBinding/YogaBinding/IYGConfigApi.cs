namespace YogaBinding
{
    internal unsafe interface IYGConfigApi
    {
        YGConfig* YGConfigNew();
        void YGConfigFree(YGConfig* config);
        YGConfig* YGConfigGetDefault();
        void YGConfigSetUseWebDefaults(YGConfig* config, bool enabled);
        bool YGConfigGetUseWebDefaults(YGConfig* config);
        void YGConfigSetPointScaleFactor(YGConfig* config, float pixelsInPoint);
        float YGConfigGetPointScaleFactor(YGConfig* config);
        void YGConfigSetErrata(YGConfig* config, YGErrata errata);
        YGErrata YGConfigGetErrata(YGConfig* config);
        void YGConfigSetLogger(YGConfig* config, delegate* unmanaged<YGConfig*, YGNode*, YGLogLevel, byte*, byte*, int> * logger);
        void YGConfigSetContext(YGConfig* config, void* context);
        void* YGConfigGetContext(YGConfig* config);
        void YGConfigSetExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature, bool enabled);
        bool YGConfigIsExperimentalFeatureEnabled(YGConfig* config, YGExperimentalFeature feature);
        void YGConfigSetCloneNodeFunc(YGConfig* config, delegate* unmanaged<YGNode*, YGNode*, ulong, YGNode*> * callback);
    }
}