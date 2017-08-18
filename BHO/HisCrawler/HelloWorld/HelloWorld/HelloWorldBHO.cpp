// HelloWorldBHO.cpp : Implementation of CHelloWorldBHO

#include "stdafx.h"
#include "HelloWorldBHO.h"


// CHelloWorldBHO

/*STDMETHODIMP CHelloWorldBHO::SetSite(IUnknown* pUnkSite)
{
	if (pUnkSite != NULL)
	{
		// Cache the pointer to IWebBrowser2.
		pUnkSite->QueryInterface(IID_IWebBrowser2, (void**)&m_spWebBrowser);
	}
	else
	{
		// Release cached pointers and other resources here.
		m_spWebBrowser.Release();
	}

	// Return the base class implementation
	return IObjectWithSiteImpl<CHelloWorldBHO>::SetSite(pUnkSite);
}*/
STDMETHODIMP CHelloWorldBHO::SetSite(IUnknown* pUnkSite)
{
	if (pUnkSite != NULL)
	{
		// Cache the pointer to IWebBrowser2.
		HRESULT hr = pUnkSite->QueryInterface(IID_IWebBrowser2, (void **)&m_spWebBrowser);
		if (SUCCEEDED(hr))
		{
			// Register to sink events from DWebBrowserEvents2.
			hr = DispEventAdvise(m_spWebBrowser);
			if (SUCCEEDED(hr))
			{
				m_fAdvised = TRUE;
			}
		}
	}
	else
	{
		// Unregister event sink.
		if (m_fAdvised)
		{
			DispEventUnadvise(m_spWebBrowser);
			m_fAdvised = FALSE;
		}

		// Release cached pointers and other resources here.
		m_spWebBrowser.Release();
	}

	// Call base class implementation.
	return IObjectWithSiteImpl<CHelloWorldBHO>::SetSite(pUnkSite);
}
void STDMETHODCALLTYPE CHelloWorldBHO::OnDocumentComplete(IDispatch *pDisp, VARIANT *pvarURL)
{
	// Retrieve the top-level window from the site.
	HWND hwnd;
	HRESULT hr = m_spWebBrowser->get_HWND((LONG_PTR*)&hwnd);
	if (SUCCEEDED(hr))
	{
		// Output a message box when page is loaded.
		MessageBox(hwnd, L"Hello World!", L"BHO", MB_OK);
	}
}