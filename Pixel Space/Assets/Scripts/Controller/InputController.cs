using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
public class InputController : MonoBehaviour 
{

    public delegate void inputEventController();

	public KeyCode  				rightControl_left,                      // equal to button Squad
				                    rightControl_up,                        // equal to button Triangle
				                    rightControl_right,                     // equal to button Circle
				                    rightControl_down,                      // equal to button X
				                    rightControlUp_Up,                      // equal to button R2
				                    rightControlUp_Down,                    // equal to button R1
				                    leftControlUp_Up,                       // equal to button L2
				                    leftControlUp_Down,                     // equal to button L1
				                    leftControl_left,                       // equal to button left arrow
				                    leftControl_up,                         // equal to button up arrow
				                    leftControl_right,                      // equal to button right arrow
				                    leftControl_down,                       // equal to button down arrow
				                    control_start,                          // equal to button start
				                    control_select;                         // equal to button select
    /// <summary>
    /// Evento Stay
    /// </summary>
    public inputEventController     ev_rightControl_left,                      // event to button Squad
                                    ev_rightControl_up,                        // event to button Triangle
                                    ev_rightControl_right,                     // event to button Circle
                                    ev_rightControl_down,                      // event to button X
                                    ev_rightControlUp_Up,                      // event to button R2
                                    ev_rightControlUp_Down,                    // event to button R1
                                    ev_leftControlUp_Up,                       // event to button L2
                                    ev_leftControlUp_Down,                     // event to button L1
                                    ev_leftControl_left,                       // event to button left arrow
                                    ev_leftControl_up,                         // event to button up arrow
                                    ev_leftControl_right,                      // event to button right arrow
                                    ev_leftControl_down,                       // event to button down arrow
                                    ev_control_start,                          // event to button start
                                    ev_control_select,                         // event to button select
                                    ev_last_frame;

    /// <summary>
    /// Evento Up
    /// </summary>
    public inputEventController ev_rightControl_left_UP,                      // event to button Squad
                                    ev_rightControl_up__UP,                        // event to button Triangle
                                    ev_rightControl_right__UP,                     // event to button Circle
                                    ev_rightControl_down__UP,                      // event to button X
                                    ev_rightControlUp_Up__UP,                      // event to button R2
                                    ev_rightControlUp_Down__UP,                    // event to button R1
                                    ev_leftControlUp_Up__UP,                       // event to button L2
                                    ev_leftControlUp_Down__UP,                     // event to button L1
                                    ev_leftControl_left_UP,                       // event to button left arrow
                                    ev_leftControl_up_UP,                         // event to button up arrow
                                    ev_leftControl_right_UP,                      // event to button right arrow
                                    ev_leftControl_down_UP,                       // event to button down arrow
                                    ev_control_start_UP,                          // event to button start
                                    ev_control_select_UP;                         // event to button select

    /// <summary>
    /// Evento Down
    /// </summary>
    public inputEventController ev_rightControl_left_DOWN,                      // event to button Squad
                                ev_rightControl_up_DOWN,                        // event to button Triangle
                                ev_rightControl_right_DOWN,                     // event to button Circle
                                ev_rightControl_down_DOWN,                      // event to button X
                                ev_rightControlUp_Up_DOWN,                      // event to button R2
                                ev_rightControlUp_Down_DOWN,                    // event to button R1
                                ev_leftControlUp_Up_DOWN,                       // event to button L2
                                ev_leftControlUp_Down_DOWN,                     // event to button L1
                                ev_leftControl_left_DOWN,                       // event to button left arrow
                                ev_leftControl_up_DOWN,                         // event to button up arrow
                                ev_leftControl_right_DOWN,                      // event to button right arrow
                                ev_leftControl_down_DOWN,                       // event to button down arrow
                                ev_control_start_DOWN,                          // event to button start
                                ev_control_select_DOWN;                        // event to button select


    private bool buttonPress = false;

    void FixedUpdate()
    {
        if (Input.anyKey)
            buttonPress = true;

        //#region GET KEY DOWN

        if (Input.GetKeyDown(this.rightControl_left))
        {
            if (this.ev_rightControl_left_DOWN != null) this.ev_rightControl_left_DOWN();
        }
        if (Input.GetKeyDown(this.rightControl_up))
        {
            if (this.ev_rightControl_up_DOWN != null) this.ev_rightControl_up_DOWN();
        }
        if (Input.GetKeyDown(this.rightControl_right))
        {
            if (this.ev_rightControl_right_DOWN != null) this.ev_rightControl_right_DOWN();
        }
        if (Input.GetKeyDown(this.rightControl_down))
        {
            if (this.ev_rightControl_down_DOWN != null) this.ev_rightControl_down_DOWN();
        }
        if (Input.GetKeyDown(this.rightControlUp_Up))
        {
            if (this.ev_rightControlUp_Up_DOWN != null) this.ev_rightControlUp_Up_DOWN();
        }
        if (Input.GetKeyDown(this.rightControlUp_Down))
        {
            if (this.ev_rightControlUp_Down_DOWN != null) this.ev_rightControlUp_Down_DOWN();
        }
        if (Input.GetKeyDown(this.leftControl_left))
        {
            if (this.ev_leftControl_left_DOWN != null) this.ev_leftControl_left_DOWN();
        }
        if (Input.GetKeyDown(this.leftControl_up))
        {
            if (this.ev_leftControl_up_DOWN != null) this.ev_leftControl_up_DOWN();
        }
        if (Input.GetKeyDown(this.leftControl_right))
        {
            if (this.ev_leftControl_right_DOWN != null) this.ev_leftControl_right_DOWN();
        }
        if (Input.GetKeyDown(this.leftControl_down))
        {
            if (this.ev_leftControl_down_DOWN != null) this.ev_leftControl_down_DOWN();
        }
        if (Input.GetKeyDown(this.control_start))
        {
            if (this.ev_control_start_DOWN != null) this.ev_control_start_DOWN();
        }
        if (Input.GetKeyDown(this.control_select))
        {
            if (this.ev_control_start_DOWN != null) this.ev_control_start_DOWN();
        }

        //#endregion

        //#region GET KEY UP

        //if (Input.GetKeyUp(this.rightControl_left))
        //{
        //    if (this.ev_rightControl_left != null) this.ev_rightControl_left();
        //}
        //if (Input.GetKeyUp(this.rightControl_up))
        //{
        //    if (this.ev_rightControl_up != null) this.ev_rightControl_up();
        //}
        //if (Input.GetKeyUp(this.rightControl_right))
        //{
        //    if (this.ev_rightControl_right != null) this.ev_rightControl_right();
        //}
        //if (Input.GetKeyUp(this.rightControl_down))
        //{
        //    if (this.ev_rightControl_down != null) this.ev_rightControl_down();
        //}
        //if (Input.GetKeyUp(this.rightControlUp_Up))
        //{
        //    if (this.ev_rightControlUp_Up != null) this.ev_rightControlUp_Up();
        //}
        //if (Input.GetKeyUp(this.rightControlUp_Down))
        //{
        //    if (this.ev_rightControlUp_Down != null) this.ev_rightControlUp_Down();
        //}
        //if (Input.GetKeyUp(this.leftControl_left))
        //{
        //    if (this.ev_leftControl_left != null) this.ev_leftControl_left();
        //}
        //if (Input.GetKeyUp(this.leftControl_up))
        //{
        //    if (this.ev_leftControl_up != null) this.ev_leftControl_up();
        //}
        //if (Input.GetKeyUp(this.leftControl_right))
        //{
        //    if (this.ev_leftControl_right != null) this.ev_leftControl_right();
        //}
        //if (Input.GetKeyUp(this.leftControl_down))
        //{
        //    if (this.ev_leftControl_down != null) this.ev_leftControl_down();
        //}
        //if (Input.GetKeyUp(this.control_start))
        //{
        //    if (this.ev_control_start != null) this.ev_control_start();
        //}
        //if (Input.GetKeyUp(this.control_select))
        //{
        //    if (this.ev_control_start != null) this.ev_control_start();
        //}

        //#endregion

        #region GET KEY 


        if (Input.GetKey(this.rightControl_left))
        {
            if (this.ev_rightControl_left != null) this.ev_rightControl_left();
        }
        if (Input.GetKey(this.rightControl_up))
        {
            if (this.ev_rightControl_up != null) this.ev_rightControl_up();
        }
        if (Input.GetKey(this.rightControl_right))
        {
            if (this.ev_rightControl_right != null) this.ev_rightControl_right();
        }
        if (Input.GetKey(this.rightControl_down))
        {
            if (this.ev_rightControl_down != null) this.ev_rightControl_down();
        }
        if (Input.GetKey(this.rightControlUp_Up))
        {
            if (this.ev_rightControlUp_Up != null) this.ev_rightControlUp_Up();
        }
        if (Input.GetKey(this.rightControlUp_Down))
        {
            if (this.ev_rightControlUp_Down != null) this.ev_rightControlUp_Down();
        }
        if (Input.GetKey(this.leftControl_left))
        {
            if (this.ev_leftControl_left != null) this.ev_leftControl_left();
        }
        if (Input.GetKey(this.leftControl_up))
        {
            if (this.ev_leftControl_up != null) this.ev_leftControl_up();
        }
        if (Input.GetKey(this.leftControl_right))
        {
            if (this.ev_leftControl_right != null) this.ev_leftControl_right();
        }
        if (Input.GetKey(this.leftControl_down))
        {
            if (this.ev_leftControl_down != null) this.ev_leftControl_down();
        }
        if (Input.GetKey(this.control_start))
        {
            if (this.ev_control_start != null) this.ev_control_start();
        }
        if (Input.GetKey(this.control_select))
        {
            if (this.ev_control_start != null) this.ev_control_start();
        }


        #endregion

        if (Input.GetKeyUp(leftControl_down) || Input.GetKeyUp(leftControl_left) || Input.GetKeyUp(leftControl_up) ||
            Input.GetKeyUp(leftControl_right))
        {
            this.eventLastFrame();
        }

        this.notEnyPressButton();

    }

    void notEnyPressButton()
    {
        if (this.buttonPress && !Input.anyKey)
        {
            this.eventLastFrame();
        }
    }

    void eventLastFrame()
    {
        if (this.ev_last_frame != null)
        {
            this.buttonPress = !this.buttonPress;
            ev_last_frame();
        }
    }

}
