#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>



// System.String
struct String_t;

IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral5D7BB3E57B2175371624738EEF9E14B3BF3C6AE0;
IL2CPP_EXTERN_C String_t* _stringLiteral6B7C46FBC097D0CA87FA46B409AA1979317BA649;
IL2CPP_EXTERN_C String_t* _stringLiteral9ED931619E39F59A8520C1E3B03FEA2E9A56FB60;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t38BB10F50960261C65DAC2863AA4E06119F13550 
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// OneSignalSDK.VspAttribution
struct VspAttribution_t879453BE5005259536B66B240BB4E45D39CBFEB5  : public RuntimeObject
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// OneSignalSDK.VspAttribution/VspAttributionData
struct VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 
{
	// System.String OneSignalSDK.VspAttribution/VspAttributionData::actionName
	String_t* ___actionName_0;
	// System.String OneSignalSDK.VspAttribution/VspAttributionData::partnerName
	String_t* ___partnerName_1;
	// System.String OneSignalSDK.VspAttribution/VspAttributionData::customerUid
	String_t* ___customerUid_2;
	// System.String OneSignalSDK.VspAttribution/VspAttributionData::extra
	String_t* ___extra_3;
};
// Native definition for P/Invoke marshalling of OneSignalSDK.VspAttribution/VspAttributionData
struct VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_pinvoke
{
	char* ___actionName_0;
	char* ___partnerName_1;
	char* ___customerUid_2;
	char* ___extra_3;
};
// Native definition for COM marshalling of OneSignalSDK.VspAttribution/VspAttributionData
struct VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_com
{
	Il2CppChar* ___actionName_0;
	Il2CppChar* ___partnerName_1;
	Il2CppChar* ___customerUid_2;
	Il2CppChar* ___extra_3;
};

// <Module>

// <Module>

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// OneSignalSDK.VspAttribution

// OneSignalSDK.VspAttribution

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Int32

// System.Int32

// OneSignalSDK.VspAttribution/VspAttributionData

// OneSignalSDK.VspAttribution/VspAttributionData
#ifdef __clang__
#pragma clang diagnostic pop
#endif



// UnityEngine.Analytics.AnalyticsResult UnityEngine.Analytics.Analytics::RegisterEvent(System.String,System.Int32,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_NO_INLINE IL2CPP_METHOD_ATTR int32_t Analytics_RegisterEvent_mC82148D11A02968E347F9D11237D50826223A7C3 (String_t* ___0_eventName, int32_t ___1_maxEventPerHour, int32_t ___2_maxItems, String_t* ___3_vendorKey, String_t* ___4_prefix, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Analytics.Analytics::get_enabled()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Analytics_get_enabled_mE4A7B84E816A7CEC2E8AB90D3165DB5B83D2C141 (const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Debug::get_isDebugBuild()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Debug_get_isDebugBuild_m9277C4A9591F7E1D8B76340B4CAE5EA33D63AF01 (const RuntimeMethod* method) ;
// System.Boolean OneSignalSDK.VspAttribution::RegisterEvent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VspAttribution_RegisterEvent_m4C34589D3242398F82CF3A944AB27C42768FB5D9 (const RuntimeMethod* method) ;
// UnityEngine.Analytics.AnalyticsResult UnityEngine.Analytics.Analytics::SendEvent(System.String,System.Object,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Analytics_SendEvent_m9E942728E301EA9E90741ADD1ED71DAD118819B5 (String_t* ___0_eventName, RuntimeObject* ___1_parameters, int32_t ___2_ver, String_t* ___3_prefix, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean OneSignalSDK.VspAttribution::RegisterEvent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VspAttribution_RegisterEvent_m4C34589D3242398F82CF3A944AB27C42768FB5D9 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5D7BB3E57B2175371624738EEF9E14B3BF3C6AE0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6B7C46FBC097D0CA87FA46B409AA1979317BA649);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		// AnalyticsResult result = Analytics.RegisterEvent(k_EventName, k_MaxEventsPerHour,
		//     k_MaxNumberOfElements, k_VendorKey);
		int32_t L_0;
		L_0 = Analytics_RegisterEvent_mC82148D11A02968E347F9D11237D50826223A7C3(_stringLiteral6B7C46FBC097D0CA87FA46B409AA1979317BA649, ((int32_t)1000), ((int32_t)1000), _stringLiteral5D7BB3E57B2175371624738EEF9E14B3BF3C6AE0, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
		// bool isResultOk = result == AnalyticsResult.Ok;
		// return isResultOk;
		return (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
	}
}
// UnityEngine.Analytics.AnalyticsResult OneSignalSDK.VspAttribution::SendAttributionEvent(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VspAttribution_SendAttributionEvent_mDC4A00C69B8FE8BEA3A4F83923B77FDC75CA185A (String_t* ___0_actionName, String_t* ___1_partnerName, String_t* ___2_customerUid, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6B7C46FBC097D0CA87FA46B409AA1979317BA649);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9ED931619E39F59A8520C1E3B03FEA2E9A56FB60);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 V_2;
	memset((&V_2), 0, sizeof(V_2));
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// bool isRuntimeAnalyticsEnabled = Analytics.enabled;
			bool L_0;
			L_0 = Analytics_get_enabled_mE4A7B84E816A7CEC2E8AB90D3165DB5B83D2C141(NULL);
			// if (!isRuntimeAnalyticsEnabled)
			if (L_0)
			{
				goto IL_000b_1;
			}
		}
		{
			// return AnalyticsResult.AnalyticsDisabled;
			V_1 = 2;
			goto IL_006d;
		}

IL_000b_1:
		{
			// if (!Debug.isDebugBuild)
			il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
			bool L_1;
			L_1 = Debug_get_isDebugBuild_m9277C4A9591F7E1D8B76340B4CAE5EA33D63AF01(NULL);
			if (L_1)
			{
				goto IL_0016_1;
			}
		}
		{
			// return AnalyticsResult.UnsupportedPlatform;
			V_1 = 7;
			goto IL_006d;
		}

IL_0016_1:
		{
			// bool isEventRegistered = RegisterEvent();
			bool L_2;
			L_2 = VspAttribution_RegisterEvent_m4C34589D3242398F82CF3A944AB27C42768FB5D9(NULL);
			// if (!isEventRegistered)
			if (L_2)
			{
				goto IL_0021_1;
			}
		}
		{
			// return AnalyticsResult.InvalidData;
			V_1 = 6;
			goto IL_006d;
		}

IL_0021_1:
		{
			// var eventData = new VspAttributionData
			// {
			//     actionName = actionName,
			//     partnerName = partnerName,
			//     customerUid = customerUid,
			//     extra = "{}"
			// };
			il2cpp_codegen_initobj((&V_2), sizeof(VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233));
			String_t* L_3 = ___0_actionName;
			(&V_2)->___actionName_0 = L_3;
			Il2CppCodeGenWriteBarrier((void**)(&(&V_2)->___actionName_0), (void*)L_3);
			String_t* L_4 = ___1_partnerName;
			(&V_2)->___partnerName_1 = L_4;
			Il2CppCodeGenWriteBarrier((void**)(&(&V_2)->___partnerName_1), (void*)L_4);
			String_t* L_5 = ___2_customerUid;
			(&V_2)->___customerUid_2 = L_5;
			Il2CppCodeGenWriteBarrier((void**)(&(&V_2)->___customerUid_2), (void*)L_5);
			(&V_2)->___extra_3 = _stringLiteral9ED931619E39F59A8520C1E3B03FEA2E9A56FB60;
			Il2CppCodeGenWriteBarrier((void**)(&(&V_2)->___extra_3), (void*)_stringLiteral9ED931619E39F59A8520C1E3B03FEA2E9A56FB60);
			VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 L_6 = V_2;
			V_0 = L_6;
			// var eventResult = Analytics.SendEvent(k_EventName, eventData);
			VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 L_7 = V_0;
			VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233 L_8 = L_7;
			RuntimeObject* L_9 = Box(VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_il2cpp_TypeInfo_var, &L_8);
			int32_t L_10;
			L_10 = Analytics_SendEvent_m9E942728E301EA9E90741ADD1ED71DAD118819B5(_stringLiteral6B7C46FBC097D0CA87FA46B409AA1979317BA649, L_9, 1, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, NULL);
			// return eventResult;
			V_1 = L_10;
			goto IL_006d;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0068;
		}
		throw e;
	}

CATCH_0068:
	{// begin catch(System.Object)
		// catch
		// return AnalyticsResult.AnalyticsDisabled;
		V_1 = 2;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_006d;
	}// end catch (depth: 1)

IL_006d:
	{
		// }
		int32_t L_11 = V_1;
		return L_11;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: OneSignalSDK.VspAttribution/VspAttributionData
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_pinvoke(const VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233& unmarshaled, VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_pinvoke& marshaled)
{
	marshaled.___actionName_0 = il2cpp_codegen_marshal_string(unmarshaled.___actionName_0);
	marshaled.___partnerName_1 = il2cpp_codegen_marshal_string(unmarshaled.___partnerName_1);
	marshaled.___customerUid_2 = il2cpp_codegen_marshal_string(unmarshaled.___customerUid_2);
	marshaled.___extra_3 = il2cpp_codegen_marshal_string(unmarshaled.___extra_3);
}
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_pinvoke_back(const VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_pinvoke& marshaled, VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233& unmarshaled)
{
	unmarshaled.___actionName_0 = il2cpp_codegen_marshal_string_result(marshaled.___actionName_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___actionName_0), (void*)il2cpp_codegen_marshal_string_result(marshaled.___actionName_0));
	unmarshaled.___partnerName_1 = il2cpp_codegen_marshal_string_result(marshaled.___partnerName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___partnerName_1), (void*)il2cpp_codegen_marshal_string_result(marshaled.___partnerName_1));
	unmarshaled.___customerUid_2 = il2cpp_codegen_marshal_string_result(marshaled.___customerUid_2);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___customerUid_2), (void*)il2cpp_codegen_marshal_string_result(marshaled.___customerUid_2));
	unmarshaled.___extra_3 = il2cpp_codegen_marshal_string_result(marshaled.___extra_3);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___extra_3), (void*)il2cpp_codegen_marshal_string_result(marshaled.___extra_3));
}
// Conversion method for clean up from marshalling of: OneSignalSDK.VspAttribution/VspAttributionData
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_pinvoke_cleanup(VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___actionName_0);
	marshaled.___actionName_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___partnerName_1);
	marshaled.___partnerName_1 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___customerUid_2);
	marshaled.___customerUid_2 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___extra_3);
	marshaled.___extra_3 = NULL;
}
// Conversion methods for marshalling of: OneSignalSDK.VspAttribution/VspAttributionData
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_com(const VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233& unmarshaled, VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_com& marshaled)
{
	marshaled.___actionName_0 = il2cpp_codegen_marshal_bstring(unmarshaled.___actionName_0);
	marshaled.___partnerName_1 = il2cpp_codegen_marshal_bstring(unmarshaled.___partnerName_1);
	marshaled.___customerUid_2 = il2cpp_codegen_marshal_bstring(unmarshaled.___customerUid_2);
	marshaled.___extra_3 = il2cpp_codegen_marshal_bstring(unmarshaled.___extra_3);
}
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_com_back(const VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_com& marshaled, VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233& unmarshaled)
{
	unmarshaled.___actionName_0 = il2cpp_codegen_marshal_bstring_result(marshaled.___actionName_0);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___actionName_0), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___actionName_0));
	unmarshaled.___partnerName_1 = il2cpp_codegen_marshal_bstring_result(marshaled.___partnerName_1);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___partnerName_1), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___partnerName_1));
	unmarshaled.___customerUid_2 = il2cpp_codegen_marshal_bstring_result(marshaled.___customerUid_2);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___customerUid_2), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___customerUid_2));
	unmarshaled.___extra_3 = il2cpp_codegen_marshal_bstring_result(marshaled.___extra_3);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___extra_3), (void*)il2cpp_codegen_marshal_bstring_result(marshaled.___extra_3));
}
// Conversion method for clean up from marshalling of: OneSignalSDK.VspAttribution/VspAttributionData
IL2CPP_EXTERN_C void VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshal_com_cleanup(VspAttributionData_t22C88EC4344A248A3EC91BE6F292BB37F83E1233_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___actionName_0);
	marshaled.___actionName_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___partnerName_1);
	marshaled.___partnerName_1 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___customerUid_2);
	marshaled.___customerUid_2 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___extra_3);
	marshaled.___extra_3 = NULL;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
