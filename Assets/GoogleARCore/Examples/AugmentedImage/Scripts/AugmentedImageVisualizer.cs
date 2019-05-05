//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class AugmentedImageVisualizer : MonoBehaviour
    {

        //General Variables
        public GameObject achNote;
        public bool achActive = false;
        public GameObject achDesc;

        //Cheives listed
        public GameObject ach01Image;
        public static int ach01Count;
        public int achTrigger = 1;
        public int ach01Code;


        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        /// <summary>
        /// A model for the lower left corner of the frame to place when an image is detected.
        /// </summary>
        public GameObject FrameLowerLeft;

        /// <summary>
        /// A model for the lower right corner of the frame to place when an image is detected.
        /// </summary>
        public GameObject FrameLowerRight;

        /// <summary>
        /// A model for the upper left corner of the frame to place when an image is detected.
        /// </summary>
        public GameObject FrameUpperLeft;

        /// <summary>
        /// A model for the upper right corner of the frame to place when an image is detected.
        /// </summary>-
        public GameObject FrameUpperRight;

       /// public GameObject object1;
       // public GameObject object2;
        public GameObject discoLib;
        public GameObject discoUpClass;
        public GameObject discoUpLab;
        public GameObject discoCLab;
        public GameObject discoB270;
        public GameObject discoLounge;
        public GameObject CsMap;
        public GameObject CsBreakroom;
        public GameObject EeLab;
        public GameObject Epidemiology;
        public GameObject GameLab;
        public GameObject GradArea;
        public GameObject ParberryOffice;
        public GameObject ProfessorsOffice;
        public int indx;

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                FrameLowerLeft.SetActive(false);
                FrameLowerRight.SetActive(false);
                FrameUpperLeft.SetActive(false);
                FrameUpperRight.SetActive(false);
               // object1.SetActive(false);
              //  object2.SetActive(false);
                discoLib.SetActive(false);
                discoUpClass.SetActive(false);
                discoUpLab.SetActive(false);
                discoCLab.SetActive(false);
                discoB270.SetActive(false);
                discoLounge.SetActive(false);
                CsMap.SetActive(false);
                CsBreakroom.SetActive(false);
                EeLab.SetActive(false);
                Epidemiology.SetActive(false);
                GameLab.SetActive(false);
                GradArea.SetActive(false);
                ParberryOffice.SetActive(false);
                ProfessorsOffice.SetActive(false);

                return;
            }

            float halfWidth = Image.ExtentX / 2;
            float halfHeight = Image.ExtentZ / 2;
            FrameLowerLeft.transform.localPosition = (halfWidth * Vector3.left) + (halfHeight * Vector3.back);
            FrameLowerRight.transform.localPosition = (halfWidth * Vector3.right) + (halfHeight * Vector3.back);
            FrameUpperLeft.transform.localPosition = (halfWidth * Vector3.left) + (halfHeight * Vector3.forward);
            FrameUpperRight.transform.localPosition = (halfWidth * Vector3.right) + (halfHeight * Vector3.forward);

            switch (indx) {
                case 0://image index number
                    //object1.transform.localPosition = (halfWidth * 2 * Vector3.up);//move txt you want forward
                    ParberryOffice.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 1:
                    //object2.transform.localPosition = (halfWidth * Vector3.up);
                    ProfessorsOffice.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 2:
                    discoLib.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 3:
                    discoUpClass.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 4:
                    discoUpLab.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 5:
                    discoCLab.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 6:
                    discoB270.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 7:
                    discoLounge.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 8:
                    CsMap.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 9:
                    CsBreakroom.transform.localPosition = (halfWidth * Vector3.up);
                    Chieves.ach01Count = 1;
                    break;
                case 10:
                    EeLab.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 11:
                    Epidemiology.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 12:
                    GameLab.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
                case 13:
                    GradArea.transform.localPosition = (halfWidth * Vector3.up);
                    StartCoroutine(Trigger01Ach());
                    break;
            }

            FrameLowerLeft.SetActive(true);
            FrameLowerRight.SetActive(true);
            FrameUpperLeft.SetActive(true);
            FrameUpperRight.SetActive(true);
            //object1.SetActive(true);
            //object2.SetActive(true);
            discoLib.SetActive(true);
            discoUpClass.SetActive(true);
            discoUpLab.SetActive(true);
            discoCLab.SetActive(true);
            discoB270.SetActive(true);
            discoLounge.SetActive(true);
            CsMap.SetActive(true);
            CsBreakroom.SetActive(true);
            EeLab.SetActive(true);
            Epidemiology.SetActive(true);
            GameLab.SetActive(true);
            GradArea.SetActive(true);
            ParberryOffice.SetActive(true);
            ProfessorsOffice.SetActive(true);
        }


        private void StartCoroutine(IEnumerable enumerable)
        {
            throw new NotImplementedException();
        }

        IEnumerable Trigger01Ach()
        {
            achActive = true;
            PlayerPrefs.SetInt("Ach01", ach01Code);
            ach01Image.SetActive(true);
            achDesc.GetComponent<Text>().text = "Decription of achievment 1";
            achNote.SetActive(true);
            yield return new WaitForSeconds(5);

            achNote.SetActive(false);
            ach01Image.SetActive(false);
            achDesc.GetComponent<Text>().text = "";
            achActive = false;
        }
    }

}
