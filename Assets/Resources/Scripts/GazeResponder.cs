// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class GazeResponder : MonoBehaviour, IGvrGazeResponder {
	private Vector3 startingPosition;

	void Start() {
		startingPosition = transform.localPosition;
		SetGazedAt(false);
	}

	void LateUpdate() {
		GvrViewer.Instance.UpdateState();
		if (GvrViewer.Instance.BackButtonPressed) {
			Application.Quit();
		}
	}

	public void SetGazedAt(bool gazedAt) {
		Debug.Log("FUCKING GAZED AT");
		//GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
	}



	#region IGvrGazeResponder implementation

	/// Called when the user is looking on a GameObject with this script,
	/// as long as it is set to an appropriate layer (see GvrGaze).
	public void OnGazeEnter() {
		Debug.Log("ENTERING GAZE");
		SetGazedAt(true);
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		Debug.Log("EXITING GAZE");
		SetGazedAt(false);
	}

	public void OnGazeTrigger() {
		Debug.Log("TRIGGERED");
	}
	#endregion
}
