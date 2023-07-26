#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Boolean OneSignalSDK.VspAttribution::RegisterEvent()
extern void VspAttribution_RegisterEvent_m4C34589D3242398F82CF3A944AB27C42768FB5D9 (void);
// 0x00000002 UnityEngine.Analytics.AnalyticsResult OneSignalSDK.VspAttribution::SendAttributionEvent(System.String,System.String,System.String)
extern void VspAttribution_SendAttributionEvent_mDC4A00C69B8FE8BEA3A4F83923B77FDC75CA185A (void);
static Il2CppMethodPointer s_methodPointers[2] = 
{
	VspAttribution_RegisterEvent_m4C34589D3242398F82CF3A944AB27C42768FB5D9,
	VspAttribution_SendAttributionEvent_mDC4A00C69B8FE8BEA3A4F83923B77FDC75CA185A,
};
static const int32_t s_InvokerIndices[2] = 
{
	5027,
	4005,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_OneSignal_UnityPackage_Attribution_CodeGenModule;
const Il2CppCodeGenModule g_OneSignal_UnityPackage_Attribution_CodeGenModule = 
{
	"OneSignal.UnityPackage.Attribution.dll",
	2,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
