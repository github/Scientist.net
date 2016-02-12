﻿using GitHub.Internals;
using System;
using System.Threading.Tasks;

namespace GitHub
{
    /// <summary>
    /// Defines an observation of an experiment's execution.
    /// </summary>
    public class Observation
    {
        /// <summary>
        /// Creates a new observation.
        /// </summary>
        /// <param name="name">The name of the experiment that was observed.</param>
        /// <param name="success">Whether the experiment was a success.</param>
        /// <param name="controlDuration">The total duration for the control experiment.</param>
        /// <param name="candidateDuration">The total duration for the candidate experiment.</param>
        /// <param name="callingMethodName">The name of the method where the experiment that was performed.</param>
        public Observation(string name, bool success, TimeSpan controlDuration, TimeSpan candidateDuration, string callingMethodName)
        {
            Name = name;
            Success = success;
            ControlDuration = controlDuration;
            CandidateDuration = candidateDuration;
            CallingMethodName = callingMethodName;
        }

        /// <summary>
        /// Gets whether the experiment was a success.
        /// </summary>
        public bool Success { get; }
        
        /// <summary>
        /// Total duration of the control experiment.
        /// <see cref="IExperiment{T}.Use(Func{T})" /> or <see cref="IExperimentAsync{T}.Use(Func{Task{T}})" />.
        /// </summary>
        public TimeSpan ControlDuration { get; }
        
        /// <summary>
        /// Total duration of the candidate experiment.
        /// <see cref="IExperiment{T}.Try(Func{T})" /> or <see cref="IExperimentAsync{T}.Try(Func{Task{T}})" />.
        /// </summary>
        public TimeSpan CandidateDuration { get; }

        /// <summary>
        /// Name of the experiment that was observed.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Name of the method where the experiment that was performed.
        /// </summary>
        public string CallingMethodName { get; }
    }
}
