// dllmain.h : Declaration of module class.

class CHelloWorldModule : public ATL::CAtlDllModuleT< CHelloWorldModule >
{
public :
	DECLARE_LIBID(LIBID_HelloWorldLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_HELLOWORLD, "{7A4EDA9D-9437-49C6-A4DE-02A928560425}")
};

extern class CHelloWorldModule _AtlModule;
