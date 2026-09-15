# Where the Feet Remember

<img alt="huayanglei02" src="https://github.com/user-attachments/assets/8fac8a8f-b6b4-4122-b228-965ebd58ea3f" />


## Short Description

**Where the Feet Remember** is a VR sensory experience that using cross-mapping underfoot physical floor textures 
with contrasting digital terrains to disrupt seamless visual immersion and bring back somatic self-
awareness by walking and moving physically in VR.


## Concept / Intent

*Where the Feet Remember* is a sensory VR experience that explores how human bodily senses, especially underfoot sensation, can be redirected toward oneself within Virtual Reality. By creating a physical-digital mismatch between the virtual landscape and underfoot physical textures, the experience heightens bodily presence. Rather than allowing users to passively dissolve into simulated content, it forces them to remain anchored in the physical body and space.

Inside the virtual maze, participants physically walk in small circles, which introduces a sense of unfamiliarity and dizziness, using this physical movement to awaken bodily imbalance and achieve awareness. Furthermore, as they rotate counterclockwise with built-up inertia, a wall suddenly appears in front of them without warning, forcing them to break their momentum and abruptly reverse direction, which serves as another way to disrupt the body balance. At the same time, materials like acupressure mats are applied on the floor to provide mild pain. Through this pain and pressure, participants are forced to allocate their attention directly to the corresponding body parts. Together, this project combines and overlays these several mechanisms to form a unified, holistic embodied experience.

Rather than treating digital immersion as a mechanism to erase and escape the physical reality, the work fuses the dual acts of "looking through" the virtual illusion and "looking at" the physical space and the body itself. Tactile foot perception serves as a critical anchor which interrupting seamless digital transport and forcing the participants to maintain a heightened, reflective awareness of their immediate, sensing body.



## Technology Used

- **Unity** — real-time VR environment, non-Euclidean maze logic, Shader Graph (vertex-warp / generative distortion shaders)
- **Meta Quest** — VR headset and wireless casting of first-person POV to an external display for spectators
- **Maya + ZBrush + Substance 3D Painter** — greybox-to-hi-poly asset pipeline; base modeling, sculpting, retopology, and PBR texture baking (normal, roughness, albedo)
- **Physical fabrication** — custom mat built from contrasting materials such as wood, carpet, yoga mat, and acupressure mats, hand-sewn and reinforced with non-slip underlayment for safety

## How to Run / Install

1. **Hardware setup:** Lay out the modular physical floor tiles to match the calibrated in-engine floor plan (see project files for the measured layout).
2. **Build & deploy:** Open the Unity project and build/deploy to a Meta Quest headset.
3. **Calibration:** On-site, align the Unity tracking anchors with the physical floor boundaries before each session — this project relies on a fixed, site-specific correspondence between physical and virtual space rather than runtime room-scale redetection.
4. **Spectator casting (optional):** Set up wireless casting from the headset to an external display so observers can see the participant's first-person view.
5. **Experience:** Put on the headset and walk. No hand controllers or avatar are used — attention is meant to stay on the feet and the ground.

## Requirements

- Unity (version used for this project — see project files)
- Meta Quest headset (Quest 2/3 or compatible)
- Modular physical floor materials matched to the virtual textures (see Concept section and project documentation for the full material list and safety build notes — non-slip underlayment, tapered foam at height transitions, edge anchoring)
- A clear physical walking area of sufficient size to accommodate the calibrated floor layout

## Screenshots / Media
<img width="5120" height="2880" alt="huayanglei01" src="https://github.com/user-attachments/assets/9fe376ff-d4f5-4a5b-a070-b10de61df4f6" />
<img width="3413" height="1920" alt="huayanglei07" src="https://github.com/user-attachments/assets/0cf6e133-4069-448a-90be-fff39fae45db" />

<img width="5120" height="2880" alt="huayanglei06" src="https://github.com/user-attachments/assets/97f8f753-4375-422a-9cc3-c7f6478d8b0e" />
<img width="5120" height="2880" alt="huayanglei05" src="https://github.com/user-attachments/assets/7fdff975-94b6-4598-bb39-5b00bdedc6b3" />
<img width="5120" height="2880" alt="huayanglei04" src="https://github.com/user-attachments/assets/a4e98da2-14c6-4b60-8f9b-d5833f372b32" />

<img width="3162" height="5120" alt="huayanglei02" src="https://github.com/user-attachments/assets/7fb83491-b7e9-44dd-a61d-fc66bd53356d" />
<img width="2480" height="3307" alt="huayanglei03" src="https://github.com/user-attachments/assets/d3842b34-efa9-452c-93df-a0e96f36f0ae" />


<img width="16779" height="11189" alt="Frame 1" src="https://github.com/user-attachments/assets/b8ba3b03-f230-4d8a-a295-740125c4e42c" />






## Credits / Acknowledgements

- **Author:** Huayang Lei

- **Special Thanks:** Yiho Li

### References

#### Theoretical References

Biocca, F. ‘The Cyborg’s Dilemma: Embodiment in Virtual Environments’. Proceedings Second International Conference on Cognitive Technology Humanizing the Information Age, August 1997, 12–26. https://doi.org/10.1109/CT.1997.617676.

Bolter, J. David. Windows and Mirrors: Interaction Design, Digital Art, and the Myth of Transparency. With Diane Gromala. Leonardo (Series) (Cambridge, Mass.). MIT Press, 2003.

Hayles, N. Katherine. How We Became Posthuman Virtual Bodies in Cybernetics, Literature, and Informatics. With American Council of Learned Societies. ACLS Humanities E-Book. University of Chicago Press, 1999. https://gold.idm.oclc.org/login?url=http://hdl.handle.net/2027/heb.05711.

Kilteni, Konstantina, Raphaela Groten, and Mel Slater. The Sense of embodiment in virtual reality. 2014. https://recercat.cat/handle/2445/53294.

Merleau-Ponty, Maurice. Phenomenology of Perception. With Donald A. Landes. Routledge, 2014.

Riva, Giuseppe, John A. Waterworth, and Eva L. Waterworth. ‘The Layers of Presence: A Bio-Cultural Approach to Understanding Presence in Natural and Mediated Environments’. CyberPsychology & Behavior 7, no. 4 (2004): 402–16. https://doi.org/10.1089/cpb.2004.7.402.

Slater, Mel. ‘Place Illusion and Plausibility Can Lead to Realistic Behaviour in Immersive Virtual Environments’. Philosophical Transactions of the Royal Society of London. Series B. Biological Sciences (England) 364, no. 1535 (2009): 3549–57. https://doi.org/10.1098/rstb.2009.0138.

University of Bristol. ‘Investigating the Somatic Body in Virtual Reality’. Accessed 16 August 2026. https://research-information.bris.ac.uk/en/studentTheses/investigating-the-somatic-body-in-virtual-reality/.

Varela, Francisco J. The Embodied Mind: Cognitive Science and Human Experience. With Evan Thompson and Eleanor Rosch. MIT Press, 1991.

Won, Andrea Stevenson, Jeremy Bailenson, Jimmy Lee, and Jaron Lanier. ‘Homuncular Flexibility in Virtual Reality’. Journal of Computer-Mediated Communication 20, no. 3 (2015): 241–59. https://doi.org/10.1111/jcc4.12107.

Zhang, Tianyuan, Wei Lin, Dingye Zhang, et al. ‘Sensing Nature’. Paper presented at ACM Designing Interactive Systems Conference 2025. 4 July 2025. https://doi.org/10.1145/3715336.3735424.

Zheng, Yuchen, Jialin Deng, Hongyue Wang, Florian ‘Floyd’ Mueller, Xueni Pan, and Marco Fyfe Pietro Gillies. ‘immersiTea: Exploring Multisensory Virtual Reality Environments to Enrich Bubble Tea Drinking Experiences’. Proceedings of the Extended Abstracts of the CHI Conference on Human Factors in Computing Systems (New York, NY, USA), CHI EA ’25, 25 April 2025, 1–7. https://doi.org/10.1145/3706599.3720228.

#### Technical References

BIFAN Official. BIFAN XR TALK | 아티스트 하이라이트: 파비토 리슈테르. 2022. 31:52. https://www.youtube.com/watch?v=uXyQuDE_zg0.

Daniel Ilett. Unity Shader Graph Basics (Part 5 - Vertex Shaders). 2024. 07:26. https://www.youtube.com/watch?v=2KSLO9JnxHA.

Delirium XR. Lavrynthos. With Rychter, Fabito, and Amir Admoni. released 2022. PC VR. https://store.steampowered.com/app/2025810/Lavrynthos/.

Disney Parks. Disney Imagineer Makes History | Disney Parks. 2024. 04:50. https://www.youtube.com/watch?v=68YMEmaF0rs.

Iwata, Hiroo, Hiroaki Yano, Hiroyuki Fukushima, and Haruo Noma. ‘CirculaFloor: A Locomotion Interface Using Circulation of Movable Tiles’. Proceedings of the 2005 IEEE Conference 2005 on Virtual Reality (USA), VR ’05, 12 March 2005, 223–30. https://doi.org/10.1109/VR.2005.11.

Le, Quang-Tri, Duc-Nham Huynh, Tanh Quang Tran, et al. ‘RedirectedStepper: Exploring Walking-In-Place Locomotion in VR Using a Mini Stepper for Ascents’. Proceedings of the 2025 CHI Conference on Human Factors in Computing Systems (New York, NY, USA), CHI ’25, 25 April 2025, 1–17. https://doi.org/10.1145/3706598.3713313.

‘Level Info: Marathon - 5-D Space - Lhowon.Org’. Accessed 9 September 2026. https://www.lhowon.org/level/marathon/30.

Márquez, Jesús Mayor. Jesusmayor/VRPortalsUnity. C#. 22 January 2021, released 13 July 2021. https://github.com/jesusmayor/VRPortalsUnity.

Paro 帕羅. Unity - Water Surface Ripple Effect Tutorial. 2023. 07:01. https://www.youtube.com/watch?v=DFwNv1n1Y6Q.

‘Persistent, Non-Euclidean Maze That Generates as You Explore. My Explanation. : U/Sean_Dewhirst’. Accessed 9 September 2026. https://www.reddit.com/user/Sean_Dewhirst/comments/1f5qjv5/persistent_noneuclidean_maze_that_generates_as/?solution=01334a7a6522ea6901334a7a6522ea69&js_challenge=1&jsc_token=7afd7253fec22262ff1c52b1703fe9ec31b3e4900e455acc53b03849141b29cc&jsc_orig_r=.

Zalwoteh Eyhalix. Marathon 5-D Space Test Map in Unity. 2020. 09:23. https://www.youtube.com/watch?v=ew8J0bJGYi4.



## Contact / Links

- **Video documentation:** https://youtu.be/uT-DcEzT9zU
- **GitHub Repository:** https://github.com/vvalhy/WheretheFeetRemember_MazeVR_FinalProject.git
