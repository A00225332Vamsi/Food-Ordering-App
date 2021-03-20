using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Food_ordering_App
{
	public class SignInResultCallback : Object, IResultCallback
	{
		public MainActivity Activity { get; set; }

		public void OnResult(Object result)
		{
			var googleSignInResult = result as GoogleSignInResult;
			Activity.HideProgressDialog();
			Activity.HandleSignInResult(googleSignInResult);
		}
	}
}