Imports System
Imports Microsoft.VisualBasic


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim capacitance As Single = 20 'Farads
        Dim ADC_cap_voltage As Single = 4 'volts
        Dim secs_to_last As Integer = 86400
        Dim active_current As Single = 0.05
        Dim active_time As Single
        Dim secs_active As Single = 0.02
        Dim voltage_min As Single = 2.65
        Dim inactive_current As Single = 0.000002
        Dim total_charge_available As Single
        Dim active_count As Integer = 1
        Dim inactive_time As Single
        Dim charge_active As Single
        Dim charge_inactive As Single
        Dim total_charge_sensor As Single
        Dim samples As Integer
        Dim sample_interval As Single
        Dim max_sample_time_secs As Integer = 1000
        Dim min_sample_time_secs As Integer = 1

        Dim sim_cap_volts As Single = 0
        Dim sim_cap_time As Single = 0
        Dim sim_max_cap_volts As Integer = 4

        Dim time(1000) As Single
        Dim cap_volts(1000) As Single
        Dim interval(1000) As Single
        Dim sim_count As Integer = 0


        'useable voltage is anything greater than 2.65V

        'as Q=CV
        'total_charge_available = (capacitance * ADC_cap_voltage) - (capacitance * 2.65)

        Do While sim_cap_time < 5
            sim_cap_volts = sim_max_cap_volts * (1 - Math.Exp(sim_cap_time * -1))
            'sim_cap_volts = 4

            total_charge_available = (capacitance * sim_cap_volts) - (capacitance * voltage_min)


            total_charge_sensor = 0
            Do While total_charge_sensor < total_charge_available
                active_time = active_count * secs_active
                inactive_time = secs_to_last - active_time
                charge_active = active_current * active_time
                charge_inactive = inactive_current * inactive_time
                total_charge_sensor = charge_active + charge_inactive
                active_count += 1
            Loop

            samples = active_count - 1
            sample_interval = secs_to_last / samples

            If total_charge_available < 0 Then
                sample_interval = max_sample_time_secs
            ElseIf sample_interval >= max_sample_time_secs Then
                sample_interval = max_sample_time_secs
            ElseIf sample_interval <= min_sample_time_secs Then
                sample_interval = min_sample_time_secs
            End If

            ' log_results

            time(sim_count) = sim_cap_time
            cap_volts(sim_count) = sim_cap_volts
            interval(sim_count) = sample_interval
            sim_cap_time += 0.01
            sim_count += 1
        Loop



    End Sub
End Class
